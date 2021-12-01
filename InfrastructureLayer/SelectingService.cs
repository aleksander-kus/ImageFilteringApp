using DomainLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace InfrastructureLayer
{
    public class SelectingService : ISelectingService
    {
        private bool[,] selected;
        public SelectingService(bool[,] selected)
        {
            this.selected = selected;
        }

        public void SelectAll(bool select)
        {
            for (int i = 0; i < selected.GetLength(0); ++i)
                for (int j = 0; j < selected.GetLength(1); ++j)
                    selected[i, j] = select;
        }

        public void SelectBrush(Point mousePosition, int brushRadius)
        {
            for (int i = Math.Max(0, mousePosition.X - brushRadius); i < Math.Min(selected.GetLength(0), mousePosition.X + brushRadius); ++i)
                for (int j = Math.Max(0, mousePosition.Y - brushRadius); j < Math.Min(selected.GetLength(1), mousePosition.Y + brushRadius); ++j)
                    if (SquaredDistance(mousePosition, new Point(i, j)) < brushRadius * brushRadius)
                        selected[i, j] = true;
        }

        public void SelectPolygon(Polygon polygon, bool select)
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
        private static int SquaredDistance(Point p1, Point p2) => (p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y);
    }
}
