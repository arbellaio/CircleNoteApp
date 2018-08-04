using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamSQLiteRelationships.ViewModels.Users;

namespace XamSQLiteRelationships.Views.Users
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddUserPage : ContentPage
	{
        AddUserViewModel addUserViewModel => BindingContext as AddUserViewModel; 
		public AddUserPage ()
		{
		    NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent ();
		}

	    private async void GoToLoginPage(object sender, EventArgs e)
	    {
	       await Navigation.PopAsync();
	    }
    }
}