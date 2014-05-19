using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Panoply.WindowsPhone.Converters
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (System.Convert.ToBoolean(parameter))
                return System.Convert.ToBoolean(value) ? Visibility.Collapsed : Visibility.Visible;
            else
                return System.Convert.ToBoolean(value) ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
