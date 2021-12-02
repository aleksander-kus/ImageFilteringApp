using System.Collections.Generic;
using System.Drawing;

namespace DomainLayer.Dto
{
    public class PolygonData
    {
        public List<Polygon> polygons { get; set; } = new List<Polygon>();
        public List<Point> addingPolygonVertices { get; set; }
        public bool AddingPolygon { get; set; } = false;
        public bool RemovingPolygon { get; set; } = false;

        public void Clear()
        {
            polygons.Clear();
            addingPolygonVertices = null;
            AddingPolygon = false;
            RemovingPolygon = false;
        }
    }
}
