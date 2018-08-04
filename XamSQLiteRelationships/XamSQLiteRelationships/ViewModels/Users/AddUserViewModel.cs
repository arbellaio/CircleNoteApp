using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using XamSQLiteRelationships.Models.Notes;
using XamSQLiteRelationships.Models.Users;
using XamSQLiteRelationships.Views.Extraviews;

namespace XamSQLiteRelationships.ViewModels.Users
{
    public class AddUserViewModel : BaseViewModel
    {
        public User User { get; set; }
        public ICommand AddUserCommand { get; set; }

        public AddUserViewModel()
        {
            User = new User();
            AddUserCommand = new Command(async () => await AddUser());
        }







        public async Task AddUser()
        {
            
            bool isUserAccept = await Application.Current.MainPage.DisplayAlert("Alert", "Wanna Register?", "Yes", "No");
            if (isUserAccept)
            {
                await App.Users.AddOrUpdateUser(User);
                await Application.Current.MainPage.Navigation.PopAsync();
            }
        }









        public string Name
        {
            get => User.Name;
            set
            {
                User.Name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public string Email
        {
            get => User.Email;
            set
            {
                User.Email = value;
                NotifyPropertyChanged("Email");
            }
        }

        public string Password
        {
            get => User.Password;
            set
            {
                User.Password = value;
                NotifyPropertyChanged("Password");
            }
        }

        public string PhoneNumber
        {
            get => User.PhoneNumber;
            set
            {
                User.PhoneNumber = value;
                NotifyPropertyChanged("PhoneNumber");
            }
        }



        public List<User> _users;
        public List<User> UsersList
        {
            get => _users;
            set
            {
                if (value != null)
                {
                    _users = value;
                    NotifyPropertyChanged("UsersList");
                }

            }
        }       
    }
}
