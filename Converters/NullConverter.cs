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
            return value is string
                ? (value ?? "").ToString().IsEmpty()
                : value == null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException("IsNullConverter can only be used OneWay.");
        }
    }
}
