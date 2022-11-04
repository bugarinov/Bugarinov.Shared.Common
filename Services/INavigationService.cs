using Bugarinov.Shared.Common.ViewModels;
using System;

namespace Bugarinov.Shared.Common.Services
{
    public interface INavigationService
    {
        BasePresenter Content { get; set; }
        void Navigate(BasePresenter presenter);
        void DialogNavigate(BasePresenter presenter, bool isDialogMode = true);
        bool ContentIs(Type type);
    }
}
