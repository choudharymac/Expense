using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using System.IO;
using Expense;
using SQLite;

[assembly: Dependency(typeof(SQLite_Android))]
namespace Expense
{
    public class SQLite_Android : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "Expense.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);
            // Create the connection
            var conn = new SQLite.SQLiteConnection(path);
            // Return the database connection
            return conn;
        }
    }
}
