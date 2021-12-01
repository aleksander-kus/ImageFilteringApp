using DomainLayer;
using DomainLayer.Filters;
using PresentationLayer.ViewLoaders;
using PresentationLayer.Views;
using System;
using System.Drawing;
using System.Linq;

namespace PresentationLayer.Presenters
{
    public class MainPresenter
    {
        private Bitmap bitmap;
        private bool[,] selected;
        private readonly IMainView view;
        private readonly IViewLoader viewLoader;
        private const int BRUSH_RADIUS = 50;
        private Filter filter;
        public Filter Filter
        {
            set
            {
                if(!filter.Function.SequenceEqual(value.Function))
                {
                    filter = value;
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
                            SelectAll();
                            UpdateBitmap();
                            break;
                        case SelectionMode.Brush:
                        case SelectionMode.Polygon:
                            UnselectAll();
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
            selected = new bool[bitmap.Width, bitmap.Height];
            SelectAll();
            filter = new NoFilter();
            UpdateBitmap();
        }

        public void RegisterCanvasClick(Point mousePosition)
        {
            if(selectionMode == SelectionMode.Brush)
            {
                SelectBrush(mousePosition);
                UpdateBitmap();
            }
        }

        public void RegisterCanvasMouseMove(Point mousePosition)
        {
            if (selectionMode == SelectionMode.Brush)
            {
                SelectBrush(mousePosition);
                UpdateBitmap();
            }
        }

        private void SelectBrush(Point mousePosition)
        {
            for (int i = Math.Max(0, mousePosition.X - BRUSH_RADIUS); i < Math.Min(bitmap.Width, mousePosition.X + BRUSH_RADIUS); ++i)
                for (int j = Math.Max(0, mousePosition.Y - BRUSH_RADIUS); j < Math.Min(bitmap.Height, mousePosition.Y + BRUSH_RADIUS); ++j)
                    if (SquaredDistance(mousePosition, new Point(i, j)) < BRUSH_RADIUS * BRUSH_RADIUS)
                        selected[i, j] = true;
        }

        private static int SquaredDistance(Point p1, Point p2) => (p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y);

        private void SelectAll()
        {
            for(int i = 0; i < selected.GetLength(0); ++i)
                for(int j = 0; j < selected.GetLength(1); ++j)
                    selected[i, j] = true;
        }
        private void UnselectAll()
        {
            for (int i = 0; i < selected.GetLength(0); ++i)
                for (int j = 0; j < selected.GetLength(1); ++j)
                    selected[i, j] = false;
        }

        private void UpdateBitmap()
        {
            GetHistogramsFromBitmap();
            FilterSelectedPoints();
        }
        private void GetHistogramsFromBitmap()
        {
            ByteBitmap byteBitmap = new ByteBitmap(bitmap);
            int[] rHistogram = new int[256];
            int[] gHistogram = new int[256];
            int[] bHistogram = new int[256];
            for (int i = 0; i < bitmap.Width; ++i)
            {
                for (int j = 0; j < bitmap.Height; ++j)
                {
                    Color color = byteBitmap.GetPixel(i, j);
                    if (color.A != 255)
                        continue;
                    ++rHistogram[color.R];
                    ++gHistogram[color.G];
                    ++bHistogram[color.B];
                }
            }
            view.RHistogram = rHistogram;
            view.GHistogram = gHistogram;
            view.BHistogram = bHistogram;
            view.RedrawHistograms();
        }

        private void FilterSelectedPoints()
        {
            ByteBitmap byteBitmap = new ByteBitmap(bitmap);
            for (int i = 0; i < bitmap.Width; ++i)
            {
                for (int j = 0; j < bitmap.Height; ++j)
                {
                    if (!selected[i, j])
                        continue;
                    Color color = byteBitmap.GetPixel(i, j);
                    if (color.A != 255)
                        continue;
                    color = filter.Transform(color);
                    byteBitmap.SetPixel(i, j, color);
                }
            }
            view.Function = filter.Function;
            view.CanvasImage = byteBitmap.Bitmap;
            view.RedrawCanvas();
        }
    }
}
