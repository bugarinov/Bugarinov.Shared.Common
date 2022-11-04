using Bugarinov.Shared.Common.Services;

namespace Bugarinov.Shared.Common.Factory
{
    public abstract class AbstractPresenterFactory
    {
        protected readonly INavigationService NavigationService;
        protected readonly IPresenterFactory PresenterFactory;

        public AbstractPresenterFactory(
            INavigationService navigationService,
            IPresenterFactory presenterFactory)
        {
            NavigationService = navigationService;
            PresenterFactory = presenterFactory;
        }
    }
}
