using System;
using System.Collections.Generic;
using System.Text;

namespace XamSQLiteRelationships.Database
{
    public interface IDatabaseConnection
    {
        string GetDatabasePath(string dbName);
    }
}
