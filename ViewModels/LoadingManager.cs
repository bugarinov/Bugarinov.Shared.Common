using Bugarinov.Shared.Common.Core;

namespace Bugarinov.Shared.Common.ViewModels
{
    public class LoadingManager : ObservableObject
    {
        private bool IsLoading_ = false;
        public bool IsLoading
        {
            get => IsLoading_;
            set
            {
                IsLoading_ = value;
                RaisePropertyChangedEvent("IsLoading");
            }
        }

        private bool IsMainEnabled_ = true;
        public bool IsMainEnabled
        {
            get => IsMainEnabled_;
            set
            {
                IsMainEnabled_ = value;
                RaisePropertyChangedEvent("IsMainEnabled");
            }
        }

        public void ShowLoad()
        {
            IsLoading = true;
            IsMainEnabled = false;
        }

        public void HideLoad()
        {
            IsLoading = false;
            IsMainEnabled = true;
        }
    }
}
