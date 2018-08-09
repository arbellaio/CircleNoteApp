using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using XamSQLiteRelationships.Models.Events;
using XamSQLiteRelationships.Models.Insurances;
using XamSQLiteRelationships.Models.Notes;
using XamSQLiteRelationships.Models.Users;
using XamSQLiteRelationships.Models.UsersEvents;

namespace XamSQLiteRelationships.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event EventHandler IsBusyChanged;

        protected virtual void OnIsBusyChanged()
        {
            IsBusyChanged?.Invoke(this, EventArgs.Empty);
        }

        readonly object _lockerIsLoading = new object();
        bool _isLoading = false;
        public bool IsLoading
        {
            get
            {
                lock (_lockerIsLoading)
                    return _isLoading;
            }
            set
            {
                lock (_lockerIsLoading)
                    if (_isLoading != value)
                    {
                        _isLoading = value;
                        NotifyPropertyChanged();
                    }
            }
        }

        readonly object _lockerIsBusy = new object();
        bool _isBusy = false;
        public bool IsBusy
        {
            get
            {
                lock (_lockerIsBusy)
                    return _isBusy;
            }
            set
            {
                lock (_lockerIsBusy)
                    if (_isBusy != value)
                    {
                        _isBusy = value;
                        NotifyPropertyChanged();
                        OnIsBusyChanged();
                    }
            }

        }

        public bool IsNotBusy => !_isBusy;

        public virtual void Initialize(object navigationData = null)
        {
        }

        public virtual Task InitializeAsync(object navigationData = null)
        {
            return Task.FromResult(false);
        }

        public Action CloseCallback;


    }
}
