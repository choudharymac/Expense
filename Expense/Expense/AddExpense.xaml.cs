using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Expense
{
    public partial class AddExpense : ContentPage
    {
        public AddExpense()
        {
            InitializeComponent();
            adddate.Text = DateTime.Today.ToString("dd-MM-yyyy");
            displayLabel.Text = "";
            amount.Text = "0";
        }
        private void OnBackspaceButtonClicked(object sender, EventArgs e)
        {
            if (displayLabel.Text.Length > 1)
                displayLabel.Text = displayLabel.Text.Remove(displayLabel.Text.Length - 1);
        }
        private void OnDigitButtonClicked(object sender, EventArgs e)
        {
            if (displayLabel.Text.Equals("Failure"))
            {
                displayLabel.Text = "";
                displayLabel.Text = displayLabel.Text + (sender as Button).Text;
            }
            else
               displayLabel.Text = displayLabel.Text + (sender as Button).Text;

        }
        private void OnValidateClicked(object sender, EventArgs e)
        {
            operation();
            Globals.Expired = "";
           
        }
        private void add(object sender, EventArgs e)
        {
            amount.Text = displayLabel.Text;
            displayLabel.Text = "";
            Globals.Expired = "+";
           
        }
        private void sub(object sender, EventArgs e)
        {
            amount.Text = displayLabel.Text;
            displayLabel.Text = "";
            Globals.Expired = "-";

        }
        private void mul(object sender, EventArgs e)
        {
            amount.Text = displayLabel.Text;
            displayLabel.Text = "";
            Globals.Expired = "*";
        }
        private void div(object sender, EventArgs e)
        {
            amount.Text = displayLabel.Text;
            displayLabel.Text = "";
            Globals.Expired = "/";
        }
        private void operation()
        {
            int x, y, z;
            switch (Globals.Expired)
            {
                case "+":
                    x = int.Parse(displayLabel.Text);
                    y = int.Parse(amount.Text);
                    z = x + y;
                    displayLabel.Text = "" + z;
                    amount.Text = "" + z;
                    break;
                case "*":
                    x = int.Parse(displayLabel.Text);
                    y = int.Parse(amount.Text);
                    z = x * y;
                    displayLabel.Text = "" + z;
                    amount.Text = "" + z;
                    break;
                case "-":
                    x = int.Parse(displayLabel.Text);
                    y = int.Parse(amount.Text);
                    z = y - x;
                    displayLabel.Text = "" + z;
                    amount.Text = "" + z;
                    break;
                case "/":
                    x = int.Parse(displayLabel.Text);
                    y = int.Parse(amount.Text);
                    z = y/ x;
                    displayLabel.Text = "" + z;
                    amount.Text = "" + z;
                    break;
                default: break;

            }
        }
    }
    public class Globals
    {
        private static String _expired;
        public static String Expired
        {
            get
            {
              
                return _expired;
            }
            set
            {
             
                _expired = value;
            }
        }
        
    }
}

