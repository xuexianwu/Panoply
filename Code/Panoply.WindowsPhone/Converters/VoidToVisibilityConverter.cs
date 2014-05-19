using System;
using System.Globalization;
using System.Windows;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Panoply.WindowsPhone.Converters
{
    public class VoidToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (System.Convert.ToBoolean(parameter))
                return String.IsNullOrEmpty(value.ToString()) ? Visibility.Visible : Visibility.Collapsed;
            else
                return String.IsNullOrEmpty(value.ToString()) ? Visibility.Collapsed : Visibility.Visible;
                
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
