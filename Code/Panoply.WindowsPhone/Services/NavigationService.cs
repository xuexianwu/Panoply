using Panoply.Common.Contracts;
using System;
using System.Windows;
using Windows.UI.Xaml.Controls;

namespace Panoply.Services
{
    public class NavigationService : INavigationService
    {
        public static Frame rootFrame { get; set; } 

        public void Navigate<T>()
        {
            rootFrame.Navigate(typeof(T));
        }

        public void Navigate(string viewName)
        {
            rootFrame.Navigate(Type.GetType(viewName));
        }

        public void Navigate<T>(object parameter)
        {
            rootFrame.Navigate(typeof(T), parameter);
        }

        public void GoBack()
        {
            if (rootFrame.CanGoBack)
                rootFrame.GoBack();
        }
    }
}