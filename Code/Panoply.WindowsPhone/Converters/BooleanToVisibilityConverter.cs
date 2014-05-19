using System;
using System.Globalization;
using System.Windows;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Panoply.WindowsPhone.Converters
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (System.Convert.ToBoolean(parameter))
                return System.Convert.ToBoolean(value) ? Visibility.Collapsed : Visibility.Visible;
            else
                return System.Convert.ToBoolean(value) ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
