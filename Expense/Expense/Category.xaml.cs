using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Expense
{
    public partial class Category : ContentPage
    {
        Random rnd = new Random();
        public Category()
        {
            InitializeComponent();
            cat1.Text =""+ rnd.Next(5, 200)+" AUD";
            cat2.Text = "" + rnd.Next(5, 200) + " AUD";
            cat3.Text = "" + rnd.Next(5, 300) + " AUD";
            cat4.Text = "" + rnd.Next(5, 600) + " AUD";
            cat5.Text = "" + rnd.Next(5, 800) + " AUD";
            cat6.Text = "" + rnd.Next(5, 400) + " AUD";
            cat7.Text = "" + rnd.Next(5, 100) + " AUD";
            cat8.Text = "" + rnd.Next(5, 200) + " AUD";
            cat9.Text = "" + rnd.Next(5, 500) + " AUD";
        }
    }
}
