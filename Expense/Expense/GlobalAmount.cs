using Android.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense
{
    public  class GlobalAmount : Application
    {
        public static int amount = 0;
             
        public static int Amount
        {
            get
            {
                // Reads are usually simple
                return amount;
            }
            set
            {
                // You can add logic here for race conditions,
                // or other measurements
                amount = value;
            }
        }
    }
}