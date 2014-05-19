namespace Panoply.Common.Contracts
{
    public interface ILocalizedSettingsService
    {
        string GetSetting(string key);
        string GetLocalizedResource(string key);
    }
}
