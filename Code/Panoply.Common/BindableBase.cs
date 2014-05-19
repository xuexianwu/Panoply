using Panoply.Common.Contracts;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Panoply.Common
{
    public abstract class BindableBase : INotifyPropertyChanged
    {
        public static IDependencyContainerService Container { get; set; }

        public void ResetViewModel<T>() where T : class
        {
            Container.ResetViewModel<T>();
        }

        protected T GetService<T>() where T : class
        {
            return Container.Resolve<T>();
        }

        protected T GetViewModel<T>() where T : class
        {
            return Container.Resolve<T>();
        }

        private bool _isBusy;

        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }
            set
            {
                Set<bool>(ref _isBusy, value);
            }
        }

        public INavigationService Navigator { get; set; }

        private INetworkService _networkMonitor;

        public INetworkService NetworkMonitor 
        {
            get 
            {
                return _networkMonitor;
            }
            set 
            {
                _networkMonitor = value;
                _networkMonitor.Initialize();
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool Set<T>(ref T storage, T value = default(T), [CallerMemberName] String propertyName = null)
        {
            if (Equals(storage, value)) return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var eventHandler = PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
