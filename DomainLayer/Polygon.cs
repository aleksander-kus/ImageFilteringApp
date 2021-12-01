using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace DomainLayer
{
    public class Polygon
    {
        public List<Point> VertexList { get; private set; }

        public Point Center { get; private set; } = new Point(0, 0);

        public Polygon(List<Point> vertices = null)
        {
            VertexList = new List<Point>(vertices);
        }

        public void RecalculateCenterPoint()
        {
            // the center point has coordinates equal to the average coords of all points
            Center = new Point(VertexList.Select(p => p.X).Aggregate((p1, p2) => p1 + p2) / VertexList.Count,
                VertexList.Select(p => p.Y).Aggregate((p1, p2) => p1 + p2) / VertexList.Count);
        }
    }
}
