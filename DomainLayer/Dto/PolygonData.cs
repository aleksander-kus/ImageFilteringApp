using System.Collections.Generic;
using System.Drawing;

namespace DomainLayer.Dto
{
    public class PolygonData
    {
        public List<Polygon> polygons { get; set; } = new List<Polygon>();
        public List<Point> addingPolygonVertices { get; set; }
        public PolygonMode PolygonMode { get; set; }

        public void Clear()
        {
            polygons.Clear();
            addingPolygonVertices = null;
            PolygonMode = PolygonMode.Adding;
        }
    }
}
