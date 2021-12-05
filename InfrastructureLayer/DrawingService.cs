using DomainLayer;
using DomainLayer.Dto;
using System.Drawing;

namespace InfrastructureLayer
{
    public class DrawingService : IDrawingService
    {
        public Bitmap OriginalBitmap { get; set; }
        private readonly PolygonData polygonData;
        private readonly ColorHistograms colorHistograms;
        private readonly FilterParameters filterParameters;
        private Bitmap exportBitmap;

        public DrawingService(Bitmap originalBitmap, PolygonData polygonData, ColorHistograms colorHistograms, FilterParameters filterParameters)
        {
            this.polygonData = polygonData;
            this.colorHistograms = colorHistograms;
            this.filterParameters = filterParameters;
            OriginalBitmap = originalBitmap;
        }

        private void DrawAddingPolygon()
        {
            using (Graphics g = Graphics.FromImage(exportBitmap))
            using (Pen p = new Pen(Color.Red, 2))
            {
                DrawVertice(polygonData.addingPolygonVertices[0], Color.Red);
                for (int i = 1; i < polygonData.addingPolygonVertices.Count; ++i)
                {
                    g.DrawLine(p, polygonData.addingPolygonVertices[i - 1], polygonData.addingPolygonVertices[i]);
                    DrawVertice(polygonData.addingPolygonVertices[i], Color.Red);
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


        public Bitmap DrawBitmap()
        {
            ByteBitmap byteBitmap = new ByteBitmap(OriginalBitmap);
            colorHistograms.Clear();
            for (int i = 0; i < byteBitmap.Width; ++i)
            {
                for (int j = 0; j < byteBitmap.Height; ++j)
                {
                    Color color = byteBitmap.GetPixel(i, j);
                    if (color.A != 255)
                        continue;
                    bool isPixelSelected = filterParameters.Selected[i, j];
                    if (isPixelSelected)
                        color = filterParameters.CurveMode == CurveMode.Normal ? filterParameters.Filter.Transform(color) : filterParameters.Filter.BezierTransform(color);
                    ++colorHistograms.RHistogram[color.R];
                    ++colorHistograms.GHistogram[color.G];
                    ++colorHistograms.BHistogram[color.B];
                    if (isPixelSelected)
                        byteBitmap.SetPixel(i, j, color);
                }
            }
            exportBitmap = byteBitmap.Bitmap;
            if (polygonData.addingPolygonVertices != null)
                DrawAddingPolygon();
            foreach (var poly in polygonData.polygons)
                DrawPolygon(poly);
            return exportBitmap;
        }
    }
}
