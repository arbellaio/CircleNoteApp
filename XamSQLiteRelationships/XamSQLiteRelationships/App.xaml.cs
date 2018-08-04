using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamSQLiteRelationships.Database.DatabaseHandler;
using XamSQLiteRelationships.Modules.Events;
using XamSQLiteRelationships.Modules.Insurances;
using XamSQLiteRelationships.Modules.Notes;
using XamSQLiteRelationships.Modules.Users;
using XamSQLiteRelationships.Providers.Colors;
using XamSQLiteRelationships.Views.Master;
using XamSQLiteRelationships.Views.MasterDetails;
using XamSQLiteRelationships.Views.Messages;
using XamSQLiteRelationships.Views.Notes;
using XamSQLiteRelationships.Views.Users;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XamSQLiteRelationships
{
	public partial class App : Application
	{
        public static LocalDatabase Database { get; private set; }
        public static IUsersModule Users { get; private set; }
        public static INotesModule Notes { get; private set; }
        public static IEventsModule Events { get; private set; }
        public static IInsurancesModule Insurances { get; private set; }


        
        
        public App ()
		{
			InitializeComponent();
		    try
		    {
                // bool IsLoggedIn = Current.Properties.ContainsKey("UserId");
                //		        if (IsLoggedIn)
                //		        {
                //		            MainPage = new NavigationPage(new MasterDetailsPage());
                //		        }
                //		        else
                //		        {
               MainPage = new NavigationPage(new LoginUserPage())
               {
                 BarBackgroundColor = Colors.TitleBarBackgroundHexColor,
		         BarTextColor = Color.White
		        
		       };


		        
            }
		    catch (Exception exception)
		    {
		        Console.WriteLine(exception);
		    }

		    // Initialize Modules
		    Initialize();
		}

	    private void Initialize()
	    {
            Users = new UsersModule();
            Notes = new NotesModule();
            Events =  new EventsModule();
            Insurances = new InsurancesModule();
            Database = new LocalDatabase();
            Database.OpenConnections();
	    }

	    protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
