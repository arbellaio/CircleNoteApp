using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamSQLiteRelationships.Database;
using XamSQLiteRelationships.Droid;
using Environment = System.Environment;

[assembly: Xamarin.Forms.Dependency(typeof(DatabaseConnection))]
namespace XamSQLiteRelationships.Droid
{
    public class DatabaseConnection : IDatabaseConnection
    {
        public string GetDatabasePath(string dbName)
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal),DatabaseConfig.DatabaseName);
            return path;
        }
    }
}