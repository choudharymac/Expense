using Android.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Expense
{
    public partial class CashWallet : ContentPage
    {
        public ListView ListView { get { return listView; } }

        ObservableCollection<AlertDrawerItems> masterPageItems = new ObservableCollection<AlertDrawerItems>();
        public CashWallet()
        {
            InitializeComponent();
            amountleft.Text ="0" + " AUD";
           
        }
        private void addmore(object sender, EventArgs args)
        {
            int sum = Int32.Parse(amountleft.Text.Substring(0, amountleft.Text.Length - 4))+ Int32.Parse(wallet.Text);
            amountleft.Text = sum + " AUD";
            masterPageItems.Add(new AlertDrawerItems
            {
                Alert = DateTime.Today.ToString("dd-MM-yyyy"),
                Amount = wallet.Text + " USD",
                IconSource = "wallet.png",
            });
            wallet.Text = "";
           
            listView.ItemsSource = masterPageItems;
            // moneywallet.IsVisible = false;
        }
    }
}
