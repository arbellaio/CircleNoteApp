using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamSQLiteRelationships.Models.Notes;
using XamSQLiteRelationships.ViewModels.Notes;

namespace XamSQLiteRelationships.Views.Notes
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddNotePage : PopupPage
	{
	    public NotesViewModel addNotesViewModel => BindingContext as NotesViewModel;

        public AddNotePage ()
		{
			InitializeComponent ();
		}

//	    protected override void OnDisappearing()
//	    {
//	        base.OnDisappearing();
//	        addNotesViewModel.RefreshCommand.Execute(null);
//	    }

	  
	}
}