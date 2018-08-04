using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamSQLiteRelationships.StringExtensions;
using XamSQLiteRelationships.Views.MasterDetails;
using XamSQLiteRelationships.Views.Messages;

namespace XamSQLiteRelationships.ViewModels.Users
{

    public class LoginViewModel : BaseViewModel
    {
        private string _email = string.Empty;

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                NotifyPropertyChanged();
            }
        }

        private string _password = string.Empty;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                NotifyPropertyChanged();
            }
        }


        public ICommand LoginCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand =  new Command(Login);
        }

        private async void Login(object obj)
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            return;
            
            if (await App.Users.LoginUser(Email, Password))
            {
                "Logged In".ToToast();
                //             await Application.Current.MainPage.Navigation.PushAsync((new MasterDetailsPage()));

                Application.Current.MainPage = new NavigationPage(new MasterDetailsPage())
                {
                    BarBackgroundColor = Color.FromHex("#F08080"),
                    BarTextColor = Color.White
                };

            }
            else
                "Wrong Email Or Password".ToToast();


        }




















    }
}
