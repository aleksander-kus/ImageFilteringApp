using DomainLayer;
using System.Drawing;

namespace InfrastructureLayer
{
    public interface ISelectingService
    {
        void SelectAll(bool select);
        void SelectBrush(Point mousePosition, int brushRadius);
        void SelectPolygon(Polygon polygon, bool select);
    }
}