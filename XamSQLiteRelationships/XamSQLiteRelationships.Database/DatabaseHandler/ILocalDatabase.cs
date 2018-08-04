using System;
using System.Collections.Generic;
using System.Text;
using XamSQLiteRelationships.Database.Events;
using XamSQLiteRelationships.Database.Insurances;
using XamSQLiteRelationships.Database.Notes;
using XamSQLiteRelationships.Database.UserEvents;
using XamSQLiteRelationships.Database.Users;

namespace XamSQLiteRelationships.Database.DatabaseHandler
{
    public interface ILocalDatabase
    {
        void OpenConnections();
        void CloseConnection();
        IUsersTable Users {get; }
        INotesTable Notes {get; }
        IEventsTable Events {get; }
        IUserEventsTable UserEvents { get; }
        IInsurancesTable Insurances{ get; }
    }
}
