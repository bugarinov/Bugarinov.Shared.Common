using Bugarinov.Shared.Common.Core;

namespace Bugarinov.Shared.Common.Classes
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
                RaisePropertyChangedEvent(nameof(IsLoading));
            }
        }

        private bool IsErrorEnabled_ = false;
        public bool IsErrorEnabled
        {
            get => IsErrorEnabled_;
            set
            {
                IsErrorEnabled_ = value;
                RaisePropertyChangedEvent(nameof(IsErrorEnabled));
            }
        }

        private bool IsMainEnabled_ = true;
        public bool IsMainEnabled
        {
            get => IsMainEnabled_;
            set
            {
                IsMainEnabled_ = value;
                RaisePropertyChangedEvent(nameof(IsMainEnabled));
            }
        }

        public void ShowLoad()
        {
            IsLoading = true;
            IsMainEnabled = false;
            IsErrorEnabled = false;
        }

        public void ShowError()
        {
            IsLoading = false;
            IsMainEnabled = false;
            IsErrorEnabled = true;
        }

        public void HideLoad()
        {
            IsLoading = false;
            IsMainEnabled = true;
            IsErrorEnabled = false;
        }
    }
}
