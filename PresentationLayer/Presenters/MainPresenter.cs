using DomainLayer;
using DomainLayer.Dto;
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
        private readonly PolygonData polygonData;
        private readonly FilterParameters filterParameters;
        private readonly ColorHistograms colorHistograms;
        private readonly IMainView view;
        private readonly IViewLoader viewLoader;
        private const int BRUSH_RADIUS = 50;

        public PolygonMode PolygonMode { get => polygonData.PolygonMode; set => polygonData.PolygonMode = value; }

        private readonly ISelectingService selectingService;
        private readonly IDrawingService drawingService;
        public Filter Filter
        {
            set => filterParameters.Filter = value;
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
                            break;
                        case SelectionMode.Brush:
                        case SelectionMode.Polygon:
                            selectingService.SelectAll(false);
                            break;
                    }
                    polygonData.Clear();
                    UpdateBitmap();
                }
            }
        }
        public MainPresenter(IMainView view, IViewLoader viewLoader)
        {
            this.view = view;
            this.viewLoader = viewLoader;

            colorHistograms = new ColorHistograms();
            this.view.ColorHistograms = colorHistograms;
            LoadBitmapFromImage(view.DefaultImage);
            filterParameters = new FilterParameters()
            {
                Selected = new bool[bitmap.Width, bitmap.Height],
                Filter = new NoFilter()
            };
            filterParameters.PropertyChanged += FilterParameters_PropertyChanged;
            selectingService = new SelectingService(filterParameters);
            selectingService.SelectAll(true);
            polygonData = new PolygonData();
            drawingService = new DrawingService(bitmap, polygonData, colorHistograms, filterParameters);
            UpdateBitmap();
        }

        public void LoadBitmapFromImage(Image image)
        {
            float scale = Math.Min((float)view.CanvasWidth / image.Width, (float)view.CanvasHeight / image.Height);
            bitmap = new Bitmap(image, new Size((int)(image.Width * scale), (int)(image.Height * scale)));
            if(drawingService != null)
            {
                filterParameters.Selected = new bool[bitmap.Width, bitmap.Height];
                drawingService.OriginalBitmap = bitmap;
                UpdateBitmap();
            }
        }
        
        public void DefineCustomFunction()
        {
            viewLoader.LoadCustomFunctionView(filterParameters);
        }

        private void FilterParameters_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) =>
            UpdateBitmap();

        public void RegisterCanvasClick(Point mousePosition)
        {
            if(selectionMode == SelectionMode.Brush)
            {
                selectingService.SelectBrush(mousePosition, BRUSH_RADIUS);
                UpdateBitmap();
            }
            else if (selectionMode == SelectionMode.Polygon && polygonData.PolygonMode == PolygonMode.Adding)
            {
                if (polygonData.addingPolygonVertices == null)
                    polygonData.addingPolygonVertices = new List<Point>();
                if(AddPointToPolygon(mousePosition))  // if a new polygon was added, add points inside to selected array
                {
                    selectingService.SelectPolygon(polygonData.polygons.Last(), true);
                }
                UpdateBitmap();
            }
            else if (selectionMode == SelectionMode.Polygon && polygonData.PolygonMode == PolygonMode.Removing)
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
            if (mousePosition.X >= bitmap.Width || mousePosition.X < 0 || mousePosition.Y >= bitmap.Height || mousePosition.Y < 0)
                return false;
            // if the first point was clicked, finish adding the new polygon
            if (polygonData.addingPolygonVertices.Count >= 3 && IsPointClicked(polygonData.addingPolygonVertices[0], mousePosition))
            {
                polygonData.polygons.Add(new Polygon(polygonData.addingPolygonVertices));
                polygonData.addingPolygonVertices = null;
                return true;
            }
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
            view.Function = filterParameters.Filter.Function;
            view.CanvasImage = drawingService.DrawBitmap();
            view.RedrawHistograms();
            view.RedrawCanvas();
        }
    }
}
