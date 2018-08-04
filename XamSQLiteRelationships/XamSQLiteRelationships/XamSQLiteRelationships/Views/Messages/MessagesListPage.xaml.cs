using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamSQLiteRelationships.Views.Master;

namespace XamSQLiteRelationships.Views.Messages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MessagesListPage : ContentPage
	{
	    private int userId;

        public MessagesListPage()
        {

            InitializeComponent();                       

        }
       	    	   
    }
}