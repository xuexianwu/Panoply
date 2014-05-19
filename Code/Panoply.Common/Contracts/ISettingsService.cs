namespace Panoply.Common.Contracts
{
    public interface ISettingsService
    {
        bool AddOrUpdateValue(string Key, object value);
        object GetValue(string key);
        void RemoveValue(string Key);
        void Save();
        bool Contains(string key);
        object GetStateValue(string key);
        void SetStateValue(string key, object value);
        void SetLanguage();
        string GetLanguage();
    }
}
