namespace Bugarinov.Shared.Common.Classes
{
    public static class GlobalLoader
    {
        private static LoadingManager LoadingManager;

        public static void SetLoader(LoadingManager loadingManager)
        {
            LoadingManager = loadingManager;
        }

        public static void ShowLoad()
        {
            LoadingManager.ShowLoad();
        }

        public static void HideLoad()
        {
            LoadingManager.HideLoad();
        }
    }
}
