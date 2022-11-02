using Bugarinov.Shared.Common.Core;

namespace Bugarinov.Shared.Common.ViewModels
{
    public class Paginator : ObservableObject
    {
        public int CurrentPage { get; private set; }

        private bool IsNextEnabled_;
        public bool IsNextEnabled
        {
            get => IsNextEnabled_;
            set
            {
                IsNextEnabled_ = value;
                RaisePropertyChangedEvent("IsNextEnabled");
            }
        }

        private bool IsPreviousEnabled_;
        public bool IsPreviousEnabled
        {
            get => IsPreviousEnabled_;
            set
            {
                IsPreviousEnabled_ = value;
                RaisePropertyChangedEvent("IsPreviousEnabled");
            }
        }

        public Paginator(int currentPage = 0)
        {
            CurrentPage = currentPage;
        }

        public void Render(int result_count)
        {
            if (CurrentPage == 0 && result_count > 0)
            {
                IsPreviousEnabled = false;
                IsNextEnabled = true;
            }
            else if (this.CurrentPage > 0 && result_count > 0)
            {
                IsPreviousEnabled = true;
                IsNextEnabled = true;
            }
            else if (this.CurrentPage > 0 && result_count == 0)
            {
                IsPreviousEnabled = true;
                IsNextEnabled = false;
            }
            else
            {
                IsPreviousEnabled = false;
                IsNextEnabled = false;
            }
        }

        public void Increment()
        {
            CurrentPage++;
        }

        public void Decrement()
        {
            CurrentPage--;
        }

        public void Reset()
        {
            CurrentPage = 0;
        }
    }
}
