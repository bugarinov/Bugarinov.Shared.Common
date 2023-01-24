using Bugarinov.Shared.Common.Core;
using Bugarinov.Shared.Common.Factory;
using Bugarinov.Shared.Common.Services;

namespace Bugarinov.Shared.Common.ViewModels
{
    public class BasePresenter : ObservableObject
    {
        protected readonly INavigationService NavigationService;
        protected readonly IPresenterFactory PresenterFactory;

        public BasePresenter(INavigationService navigationService, IPresenterFactory presenterFactory)
        {
            NavigationService = navigationService;
            PresenterFactory = presenterFactory;
        }

        public virtual void Load() { }

        public virtual void Unload() { }
    }
}
