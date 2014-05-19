namespace Panoply.Common.Contracts
{   
    public interface INavigationService
    {
        void Navigate<T>();
        void Navigate(string viewName);
        void Navigate<T>(object parameter);
        void GoBack();
    }
}
