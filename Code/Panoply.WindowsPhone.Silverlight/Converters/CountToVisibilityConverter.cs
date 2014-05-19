using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Panoply.WindowsPhone.Converters
{
    public class CountToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (System.Convert.ToBoolean(parameter))
                return System.Convert.ToInt32(value) > 0 ? Visibility.Visible : Visibility.Collapsed;
            else
                return System.Convert.ToInt32(value) > 0 ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
