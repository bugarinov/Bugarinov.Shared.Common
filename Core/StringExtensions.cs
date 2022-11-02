namespace Bugarinov.Shared.Common.Core
{
    public static class StringExtensions
    {
        public static bool IsEmpty(this string obj)
        {
            return (obj ?? "").Trim().Length == 0;
        }
    }
}
