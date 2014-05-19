using Panoply.Common.Contracts;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Panoply.Services
{
    public class NavigationService : INavigationService
    {
        public void Navigate<T>()
        {
            (Application.Current.RootVisual as Frame)
                .Navigate(new Uri("/" + typeof(T).Name, UriKind.Relative));
        }

        public void Navigate(string viewName)
        {
            (Application.Current.RootVisual as Frame)
                .Navigate(new Uri("/Pages/" + viewName + ".xaml", UriKind.Relative));
        }

        public void Navigate<T>(object parameter)
        {
            throw new NotImplementedException();
        }

        public void GoBack()
        {
            if ((Application.Current.RootVisual as Frame).CanGoBack)
                (Application.Current.RootVisual as Frame).GoBack();
        }
    }
}