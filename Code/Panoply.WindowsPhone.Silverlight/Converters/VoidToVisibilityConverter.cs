using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Panoply.WindowsPhone.Converters
{
    public class VoidToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (System.Convert.ToBoolean(parameter))
                return String.IsNullOrEmpty(value.ToString()) ? Visibility.Visible : Visibility.Collapsed;
            else
                return String.IsNullOrEmpty(value.ToString()) ? Visibility.Collapsed : Visibility.Visible;
                
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
