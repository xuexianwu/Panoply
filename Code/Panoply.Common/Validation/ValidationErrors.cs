﻿//Source: http://csharperimage.jeremylikness.com/2013/06/simple-validation-with-mvvm-for-windows.html
namespace Panoply.Common.Validation
{
    using System.Collections.Generic;

    public class ValidationErrors : BindableBase 
    {
        private readonly Dictionary<string, string> validationErrors = new Dictionary<string, string>();

        public bool IsValid
        {
            get
            {
                return validationErrors.Count < 1;
            }
        }

        public string this[string fieldName]
        {
            get
            {
                return validationErrors.ContainsKey(fieldName) ? 
                    validationErrors[fieldName] : string.Empty;
            }

            set
            {
                if (validationErrors.ContainsKey(fieldName))
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        validationErrors.Remove(fieldName);
                    }
                    else
                    {
                        validationErrors[fieldName] = value;
                    }
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        validationErrors.Add(fieldName, value);
                    }
                }

                OnPropertyChanged();
                OnPropertyChanged("IsValid");
            }
        }

        public void Clear()
        {
            var keyList = new string[validationErrors.Count];
            validationErrors.Keys.CopyTo(keyList, 0);
            
            foreach (var key in keyList)
            {
                this[key] = string.Empty;
            }
        }
    }
}