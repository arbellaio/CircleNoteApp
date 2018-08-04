using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;
using XamSQLiteRelationships.Database.Events;
using XamSQLiteRelationships.Database.Insurances;
using XamSQLiteRelationships.Database.Notes;
using XamSQLiteRelationships.Database.UserEvents;
using XamSQLiteRelationships.Database.Users;
using XamSQLiteRelationships.Models.Events;
using XamSQLiteRelationships.Models.Insurances;
using XamSQLiteRelationships.Models.Notes;
using XamSQLiteRelationships.Models.Users;
using XamSQLiteRelationships.Models.UsersEvents;

namespace XamSQLiteRelationships.Database.DatabaseHandler
{
    public class LocalDatabase : ILocalDatabase
    {

        private readonly string _databasePath;
        private SQLiteAsyncConnection _database;

        public SQLiteAsyncConnection Database
        {
            get
            {
                if (_database == null)                
                    OpenConnections();
                    return _database;
                
            }


        }



        public virtual IUsersTable Users { get; private set; }
        public virtual INotesTable Notes { get; private set; }
        public virtual IEventsTable Events { get; private set; }
        public virtual IInsurancesTable Insurances { get; private set; }
        public virtual IUserEventsTable UserEvents{ get; private set; }



        public LocalDatabase()
        {
            _databasePath = DependencyService.Get<IDatabaseConnection>().GetDatabasePath(DatabaseConfig.DatabaseName);
            try
            {
                Initialize();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                CloseConnection();
            }           
        }
        public void Initialize()
        {
            OpenConnections();
            Users = new UsersTable(this);
            Notes = new NotesTable(this);
            UserEvents = new UserEventsTable(this);
            Insurances = new InsurancesTable(this);
            Events = new EventsTable(this);
        }


        public void OpenConnections()
        {
            _database = new SQLiteAsyncConnection(_databasePath);
            CreateDatabaseTables();
        }

        public void CreateDatabaseTables()
        {
            _database.CreateTableAsync<User>();
            _database.CreateTableAsync<UserEvent>();
            _database.CreateTableAsync<Event>();
            _database.CreateTableAsync<Note>();
            _database.CreateTableAsync<Insurance>();
        }

        public void CloseConnection()
        {
            if (_database != null)
            {
                _database = null;
            }
        }
    }
}
