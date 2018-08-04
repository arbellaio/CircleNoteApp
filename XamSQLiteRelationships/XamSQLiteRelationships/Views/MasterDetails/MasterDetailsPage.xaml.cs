using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamSQLiteRelationships.Providers.Colors;
using XamSQLiteRelationships.Views.Master;
using XamSQLiteRelationships.Views.Messages;

namespace XamSQLiteRelationships.Views.MasterDetails
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterDetailsPage : MasterDetailPage
	{

        public MasterDetailsPage()
		{
			InitializeComponent();
            
		 
            
            Master = new MasterPage();             
            Detail = new NavigationPage(new MessagesListPage())
		    {
		        BarBackgroundColor = Colors.TitleBarBackgroundHexColor,
		        BarTextColor = Color.White
		    };             
           
		    MessagingCenter.Subscribe<MasterPage>(this, "CloseMenu", (sender) => {
		        IsPresented = false;
		    });


        }





    }
}