using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamSQLiteRelationships.ViewModels.Users;
using XamSQLiteRelationships.Views.Master;
using XamSQLiteRelationships.Views.MasterDetails;
using XamSQLiteRelationships.Views.Messages;

namespace XamSQLiteRelationships.Views.Users
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginUserPage : ContentPage
	{
        public LoginViewModel loginViewModel => BindingContext as LoginViewModel;
        

		public LoginUserPage ()
		{
            InitializeComponent ();            
		}

        private async void GotoRegisterationPage(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new AddUserPage());
        }

      
    }
}