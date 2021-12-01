using DomainLayer;
using DomainLayer.Filters;
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
        private Bitmap exportBitmap;
        private bool[,] selected;
        private readonly IMainView view;
        private readonly IViewLoader viewLoader;
        private const int BRUSH_RADIUS = 50;
        private Filter filter;
        private List<Polygon> polygons { get; set; } = new List<Polygon>();
        private List<Point> addingPolygonVertices { get; set; }
        private bool addingPolygon = false;
        private bool removingPolygon = false;
        public bool AddingPolygon { get => addingPolygon; set => addingPolygon = value; }
        public bool RemovingPolygon { get => removingPolygon; set => removingPolygon = value; }
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
                            polygons.Clear();
                            addingPolygonVertices = null;
                            addingPolygon = false;
                            removingPolygon = false;
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
            else if (selectionMode == SelectionMode.Polygon && addingPolygon)
            {
                if (addingPolygonVertices == null)
                    addingPolygonVertices = new List<Point>();
                if(AddPointToPolygon(mousePosition))  // if a new polygon was added, add points inside to selected array
                {
                    ScanLineSelecting(polygons.Last(), true);
                }
                UpdateBitmap();
            }
            else if (selectionMode == SelectionMode.Polygon && removingPolygon)
            {
                int id;
                if((id = IsPolygonCenterClicked(mousePosition)) != -1)
                {
                    ScanLineSelecting(polygons[id], false);
                    polygons.RemoveAt(id);
                }
                UpdateBitmap();
            }
        }

        private bool AddPointToPolygon(Point mousePosition)
        {
            // if the first point was clicked, finish adding the new resources.polygon
            if (addingPolygonVertices.Count >= 3 && IsPointClicked(addingPolygonVertices[0], mousePosition))
            {
                //addingPolygonVertices.RemoveAt(addingPolygonVertices.Count - 1);
                polygons.Add(new Polygon(addingPolygonVertices));
                addingPolygonVertices = null;
                addingPolygon = false;
                return true;
            }
            // else add a new point to the resources.polygon
            else
                addingPolygonVertices.Add(mousePosition);
            return false;
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

        public int IsPolygonCenterClicked(Point mousePosition)
        {
            for (int i = 0; i < polygons.Count; ++i)
                if (IsPointClicked(polygons[i].Center, mousePosition))
                    return i;
            return -1;
        }
        private static int SquaredDistance(Point p1, Point p2) => (p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y);
        private static bool IsPointClicked(Point point, Point mousePosition, int epsilon = 10) => SquaredDistance(point, mousePosition) <= epsilon * epsilon;
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

        private void DrawAddingPolygon()
        {
            using (Graphics g = Graphics.FromImage(exportBitmap))
            using (Pen p = new Pen(Color.Red, 2))
            {
                DrawVertice(addingPolygonVertices[0], Color.Red);
                for (int i = 1; i < addingPolygonVertices.Count; ++i)
                {
                    g.DrawLine(p, addingPolygonVertices[i - 1], addingPolygonVertices[i]);
                    DrawVertice(addingPolygonVertices[i], Color.Red);
                }
            }
        }

        private void DrawPolygon(Polygon polygon)
        {
            using (Graphics g = Graphics.FromImage(exportBitmap))
            using (Pen p = new Pen(Color.Red, 2))
            {
                DrawVertice(polygon.VertexList[0], Color.Red);
                for (int i = 1; i <= polygon.VertexList.Count; ++i)
                {
                    g.DrawLine(p, polygon.VertexList[i - 1], polygon.VertexList[i % polygon.VertexList.Count]);
                    DrawVertice(polygon.VertexList[i % polygon.VertexList.Count], Color.Red);
                }
                DrawVertice(polygon.Center, Color.Red);

            }
        }

        private void DrawVertice(Point location, Color? color = null)
        {
            using (Graphics g = Graphics.FromImage(exportBitmap))
            using (Brush b = new SolidBrush(color ?? Color.Green))
            using (Pen p = new Pen(Color.Black, 1))
            {
                Rectangle r = new Rectangle() { X = location.X - 3, Y = location.Y - 3, Height = 6, Width = 6 };
                g.FillEllipse(b, r);
                g.DrawEllipse(p, r);
            }
        }


        private void UpdateBitmap()
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
                    bool s = selected[i, j];
                    if (s)
                        color = filter.Transform(color);
                    ++rHistogram[color.R];
                    ++gHistogram[color.G];
                    ++bHistogram[color.B];
                    if (s)
                        byteBitmap.SetPixel(i, j, color);
                }
            }
            view.Function = filter.Function;
            exportBitmap = byteBitmap.Bitmap;
            view.RHistogram = rHistogram;
            view.GHistogram = gHistogram;
            view.BHistogram = bHistogram;
            if (addingPolygonVertices != null)
                DrawAddingPolygon();
            foreach (var poly in polygons)
                DrawPolygon(poly);
            view.CanvasImage = exportBitmap;
            view.RedrawHistograms();
            view.RedrawCanvas();
        }

        private void ScanLineSelecting(Polygon polygon, bool select)
        {
            var vertexList = polygon.VertexList;
            (double X, double Y, int index)[] P = vertexList.Select((point, index) => ((double)point.X, (double)point.Y, index)).OrderBy(shape => shape.Item2).ToArray();
            List<(int y_max, double x, double m)> AET = new List<(int y_max, double x, double m)>();
            int ymin = (int)P[0].Y;
            int ymax = (int)P.Last().Y;
            int current_index = 0;
            for (int y = ymin; y <= ymax; ++y)
            {
                // For each point that was on the previous line
                while (P[current_index].Y == y - 1)
                {
                    var current_point = P[current_index];
                    // Find adjacent points
                    var previous_point = Array.Find(P, p => p.index == (current_point.index - 1 + P.Length) % P.Length);
                    var next_point = Array.Find(P, p => p.index == (current_point.index + 1 + P.Length) % P.Length);
                    if (previous_point.Y > current_point.Y)
                    {
                        double m = (current_point.Y - previous_point.Y) / (current_point.X - previous_point.X);
                        if (m != 0)
                            AET.Add(((int)previous_point.Y, P[current_index].X + 1 / m, m));
                    }
                    else
                    {
                        AET.RemoveAll(item => item.y_max == current_point.Y);
                    }
                    if (next_point.Y > current_point.Y)
                    {
                        double m = (current_point.Y - next_point.Y) / (current_point.X - next_point.X);
                        if (m != 0)
                            AET.Add(((int)next_point.Y, P[current_index].X + 1 / m, m));
                    }
                    else
                    {
                        AET.RemoveAll(item => item.y_max == current_point.Y);
                    }
                    ++current_index;
                }
                // Sort edges according to x
                AET.Sort((item1, item2) => item1.x.CompareTo(item2.x));
                // Fill pixels between every pair of edges
                for (int i = 0; i < AET.Count; i += 2)
                    for (int x = (int)Math.Round(AET[i].x); x < AET[i + 1].x; ++x)
                        selected[x, y] = select;
                // Update the x value for each edge
                for (int i = 0; i < AET.Count; ++i)
                {
                    var (y_max, x, m) = AET[i];
                    AET[i] = (y_max, x + 1 / m, m);
                }
            }
        }
    }
}
