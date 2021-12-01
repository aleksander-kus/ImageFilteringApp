using DomainLayer;
using DomainLayer.Filters;
using InfrastructureLayer;
using PresentationLayer.ViewLoaders;
using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace PresentationLayer.Presenters
{
    public class MainPresenter
    {
        private Bitmap bitmap;
        private PolygonData polygonData;
        private FilterParameters filterParameters;
        private ColorHistograms colorHistograms;
        private readonly IMainView view;
        private readonly IViewLoader viewLoader;
        private const int BRUSH_RADIUS = 50;


        public bool AddingPolygon { get => polygonData.AddingPolygon; set => polygonData.AddingPolygon = value; }
        public bool RemovingPolygon { get => polygonData.RemovingPolygon; set => polygonData.RemovingPolygon = value; }

        private readonly ISelectingService selectingService;
        private readonly IDrawingService drawingService;
        public Filter Filter
        {
            set
            {
                if(!filterParameters.filter.Function.SequenceEqual(value.Function))
                {
                    filterParameters.filter = value;
                    UpdateBitmap();
                }
            }
        }
        private SelectionMode selectionMode = SelectionMode.Whole;
        public SelectionMode SelectionMode
        {
            set
            {
                if(selectionMode != value)
                {
                    selectionMode = value;
                    switch(selectionMode)
                    {
                        case SelectionMode.Whole:
                            selectingService.SelectAll(true);
                            UpdateBitmap();
                            break;
                        case SelectionMode.Brush:
                        case SelectionMode.Polygon:
                            selectingService.SelectAll(false);
                            polygonData.Clear();
                            UpdateBitmap();
                            break;
                    }
                }
            }
        }
        public MainPresenter(IMainView view, IViewLoader viewLoader)
        {
            this.view = view;
            this.viewLoader = viewLoader;

            bitmap = new Bitmap(view.DefaultImage);
            this.view.CanvasImage = bitmap;
            colorHistograms = new ColorHistograms();
            this.view.ColorHistograms = colorHistograms;
            filterParameters = new FilterParameters()
            {
                selected = new bool[bitmap.Width, bitmap.Height],
                filter = new NoFilter()
            };
            selectingService = new SelectingService(filterParameters.selected);
            selectingService.SelectAll(true);
            polygonData = new PolygonData();
            drawingService = new DrawingService(bitmap, polygonData, colorHistograms, filterParameters);
            UpdateBitmap();
        }

        public void RegisterCanvasClick(Point mousePosition)
        {
            if(selectionMode == SelectionMode.Brush)
            {
                selectingService.SelectBrush(mousePosition, BRUSH_RADIUS);
                UpdateBitmap();
            }
            else if (selectionMode == SelectionMode.Polygon && polygonData.AddingPolygon)
            {
                if (polygonData.addingPolygonVertices == null)
                    polygonData.addingPolygonVertices = new List<Point>();
                if(AddPointToPolygon(mousePosition))  // if a new polygon was added, add points inside to selected array
                {
                    selectingService.SelectPolygon(polygonData.polygons.Last(), true);
                }
                UpdateBitmap();
            }
            else if (selectionMode == SelectionMode.Polygon && polygonData.RemovingPolygon)
            {
                int id;
                if((id = IsPolygonCenterClicked(mousePosition)) != -1)
                {
                    selectingService.SelectPolygon(polygonData.polygons[id], false);
                    polygonData.polygons.RemoveAt(id);
                }
                UpdateBitmap();
            }
        }

        private bool AddPointToPolygon(Point mousePosition)
        {
            // if the first point was clicked, finish adding the new resources.polygon
            if (polygonData.addingPolygonVertices.Count >= 3 && IsPointClicked(polygonData.addingPolygonVertices[0], mousePosition))
            {
                //polygonData.polygonData.addingPolygonVertices.RemoveAt(polygonData.polygonData.addingPolygonVertices.Count - 1);
                polygonData.polygons.Add(new Polygon(polygonData.addingPolygonVertices));
                polygonData.addingPolygonVertices = null;
                polygonData.AddingPolygon = false;
                return true;
            }
            // else add a new point to the resources.polygon
            else
                polygonData.addingPolygonVertices.Add(mousePosition);
            return false;
        }

        public void RegisterCanvasMouseMove(Point mousePosition)
        {
            if (selectionMode == SelectionMode.Brush)
            {
                selectingService.SelectBrush(mousePosition, BRUSH_RADIUS);
                UpdateBitmap();
            }
        }

        public int IsPolygonCenterClicked(Point mousePosition)
        {
            for (int i = 0; i < polygonData.polygons.Count; ++i)
                if (IsPointClicked(polygonData.polygons[i].Center, mousePosition))
                    return i;
            return -1;
        }
        private static int SquaredDistance(Point p1, Point p2) => (p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y);
        private static bool IsPointClicked(Point point, Point mousePosition, int epsilon = 10) => SquaredDistance(point, mousePosition) <= epsilon * epsilon;

        private void UpdateBitmap()
        {
            view.Function = filterParameters.filter.Function;
            view.CanvasImage = drawingService.DrawBitmap();
            view.RedrawHistograms();
            view.RedrawCanvas();
        }
    }
}
