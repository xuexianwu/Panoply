using System;
using System.Globalization;
using System.Windows;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Panoply.WindowsPhone.Converters
{
    public class CountToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (System.Convert.ToBoolean(parameter))
                return System.Convert.ToInt32(value) > 0 ? Visibility.Visible : Visibility.Collapsed;
            else
                return System.Convert.ToInt32(value) > 0 ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
