//Source: http://csharperimage.jeremylikness.com/2013/06/simple-validation-with-mvvm-for-windows.html
namespace Panoply.Common.Validation
{
    public abstract class ValidationBase : BindableBase
    {
        protected ValidationBase()
        {
            ValidationErrors = new ValidationErrors();            
        }

        private ValidationErrors validationErrors;

        public ValidationErrors ValidationErrors
        {
            get
            {
                return validationErrors;
            }
            set
            {
                Set<ValidationErrors>(ref validationErrors, value);
            }
        }
        

        public bool IsValid { get; private set; }

        public void Validate()
        {
            ValidationErrors.Clear();
            ValidateSelf();
            IsValid = ValidationErrors.IsValid;

            OnPropertyChanged("IsValid");

            OnPropertyChanged("ValidationErrors");
        }

        protected abstract void ValidateSelf();
    }
}