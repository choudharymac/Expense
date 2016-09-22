using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Expense
{
    class Database
    {
        private SQLiteConnection _sqlconnection;

        public Database()
        {
            //Getting conection and Creating table  
            _sqlconnection = DependencyService.Get<ISQLite>().GetConnection();
            _sqlconnection.CreateTable<ExpenseDB>();
        }

        //Get all students  
        public IEnumerable<ExpenseDB> GetStudents()
        {
            return (from t in _sqlconnection.Table<ExpenseDB>() select t).ToList();
        }

        //Get specific student  
        public ExpenseDB GetStudent(String id)
        {
            return _sqlconnection.Table<ExpenseDB>().FirstOrDefault(t => t.Category == id);
        }

        //Delete specific student  
        public void DeleteStudent(int id)
        {
            _sqlconnection.Delete<ExpenseDB>(id);
        }

        //Add new student to DB  
        public void AddStusent(ExpenseDB student)
        {
            _sqlconnection.Insert(student);
        }
    }
}

