using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamSQLiteRelationships.Views.Friends;
using XamSQLiteRelationships.Views.Groups;
using XamSQLiteRelationships.Views.Insurances;
using XamSQLiteRelationships.Views.MasterDetails;
using XamSQLiteRelationships.Views.Messages;
using XamSQLiteRelationships.Views.Notes;
using XamSQLiteRelationships.Views.Users;
using static Xamarin.Forms.Application;
using NavigationPage = Xamarin.Forms.PlatformConfiguration.GTKSpecific.NavigationPage;

namespace XamSQLiteRelationships.Views.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : ContentPage
	{
	   
        public MasterPage()
		{
			InitializeComponent();
		   
        }

        private void GotoChatPage(object sender, EventArgs e)
        {
            MessagingCenter.Send<MasterPage>(this, "CloseMenu");         
        }


	    private async void GotoProfilePage(object sender, EventArgs e)
	    {
            await Navigation.PushAsync(new ProfilePage());       
	    }

        private async void GotoFriendsPage(object sender, EventArgs e)
	    {	       
            await Navigation.PushAsync(new FriendsPage());
        }

        private async void GotoCirclePage(object sender, EventArgs e)
	    {
            await Navigation.PushAsync(new EventsPage());
        }

        private async void GotoNotesPage(object sender, EventArgs e)
	    {
            await Navigation.PushAsync(new NotesPage());
        }

        private async void GotoInsurancePage(object sender, EventArgs e)
	    {	     
            await Navigation.PushAsync(new InsurancePage());
        }

	   
	}
}