namespace Panoply.Common.Contracts
{
    public interface IPhoneService
    {
        void Vibrate(int seconds);
        void PlaySound(string path);
        void ShowMessage(string title, string message);
        void ShowToastNotification(string title, string message);
        void NavigateToUri(string url);
        bool ShowConfirmationMessage(string title, string message);
    }
}