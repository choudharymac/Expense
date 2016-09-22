using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense
{
    class ExpenseDB
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Amount { get; set; }
        public string Category { get; set; }
        public string Date { get; set; }

        public ExpenseDB()
        {
        }
    }
}
