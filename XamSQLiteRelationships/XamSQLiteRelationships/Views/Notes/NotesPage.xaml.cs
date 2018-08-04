using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamSQLiteRelationships.Models.Notes;
using XamSQLiteRelationships.Models.Users;
using XamSQLiteRelationships.ViewModels.Notes;

namespace XamSQLiteRelationships.Views.Notes
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NotesPage : ContentPage
	{
        public NotesViewModel notesViewModel => BindingContext as NotesViewModel;
        public NotesPage ()
		{
			InitializeComponent();
            notesListView.ItemSelected += (sender, e) => { ((ListView)sender).SelectedItem = null; };
            
		}
	    
	    private async void FloatingActionButton_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushPopupAsync(new AddNotePage());
        }


    }
}