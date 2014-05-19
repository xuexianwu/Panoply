using System.Globalization;
using Panoply.Common.Contracts;
using System;

namespace Panoply.Services
{
    public class SettingsService : ISettingsService
    {
        public object GetValue(string key)
        {
            //if (IsolatedStorageSettings.ApplicationSettings.Contains(key))
            //{
            //    return IsolatedStorageSettings.ApplicationSettings[key];
            //}
            return null;
        }

        public bool AddOrUpdateValue(string Key, Object value)
        {
            bool valueChanged = false;
            //IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;

            //if (settings.Contains(Key))
            //{
            //    if (settings[Key] != value)
            //    {
            //        settings[Key] = value;
            //        valueChanged = true;
            //    }
            //}
            //else
            //{
            //    settings.Add(Key, value);
            //    valueChanged = true;
            //}
            return valueChanged;
        }

        public bool Contains(string key)
        {
            //return IsolatedStorageSettings.ApplicationSettings.Contains(key);
        }

        public void Save()
        {
            //IsolatedStorageSettings.ApplicationSettings.Save();
        }

        public void RemoveValue(string Key)
        {
            //IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;

            //if (settings.Contains(Key))
            //{
            //    settings.Remove(Key);
            //}
        }

        public object GetStateValue(string key)
        {
            //if (PhoneApplicationService.Current.State.ContainsKey(key))
            //{
            //    return PhoneApplicationService.Current.State[key] as string;
            //}

            //return null;
        }

        public void SetStateValue(string key, object value)
        {
            //PhoneApplicationService.Current.State[key] = value;
        }

        public void SetLanguage()
        {
            //string idioma = CultureInfo.CurrentUICulture.Parent.ToString().ToLower();

            //if (!idioma.Equals("en") && !idioma.Equals("es"))
            //{
            //    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            //}
        }

        public string GetLanguage()
        {
            return CultureInfo.CurrentUICulture.Parent.ToString().ToLower();
        }
    }
}
