using System;
using System.Collections.Generic;
using System.Text;
using XamSQLiteRelationships.Database.DatabaseHandler;

namespace XamSQLiteRelationships.Database.UserEvents
{
    public interface IUserEventsTable
    {
//        public TYPE NAME { get; set; }
    }

    public class UserEventsTable : IUserEventsTable
    {
        public LocalDatabase Handler { get; set; }

        public UserEventsTable(LocalDatabase _database)
        {
            if (_database == null)
            {
                throw new ArgumentNullException("Database");
            }
            else
            {
                Handler = _database;
            }
        }
    }
}
