using Android.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Expense
{
    public partial class CashWallet : ContentPage
    {
        public CashWallet()
        {
            InitializeComponent();
            amountleft.Text ="0" + " AUD";
        }
        private void addmore(object sender, EventArgs args)
        {
            int sum = Int32.Parse(amountleft.Text.Substring(0, amountleft.Text.Length - 4))+ Int32.Parse(wallet.Text);
            amountleft.Text = sum + " AUD";
            wallet.Text = "";
            moneywallet.IsVisible = false;
       }
    }
}
