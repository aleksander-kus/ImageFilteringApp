using DomainLayer.Dto;

namespace PresentationLayer.ViewLoaders
{
    public interface IViewLoader
    {
        void LoadMainView();
        void LoadCustomFunctionView(FilterParameters filterParameters);
    }
}
