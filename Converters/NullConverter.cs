using Bugarinov.Shared.Common.Core;
using System;
using System.Globalization;
using System.Windows.Data;

namespace Bugarinov.Shared.Common.Converters
{
    public class NullConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value ?? "").ToString().IsEmpty();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException();
        }
    }
}
