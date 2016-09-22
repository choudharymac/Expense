using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Expense
{
    public partial class Feed : ContentPage
    {
        public ListView ListView { get { return listView; } }

        ObservableCollection<AlertDrawerItems> masterPageItems = new ObservableCollection<AlertDrawerItems>();

        public Feed()
        {
            InitializeComponent();
            InfiniteLoop();
            totalamount.Text = "AUD " + "1000";
            moneyspend.Text = "AUD " + "210";
            if (!GlobalVariable.Cat.Equals(""))
            {
                masterPageItems.Add(new AlertDrawerItems
                {
                    Alert = GlobalVariable.Cat,
                    Amount = GlobalAmount.Amount + " USD",
                    IconSource = "wallet.png",
                });

            }
            masterPageItems.Add(new AlertDrawerItems
            {
                Alert = "Food",
                Amount ="30"+ " USD",
                IconSource = "wallet.png",
            });
            masterPageItems.Add(new AlertDrawerItems
            {
                Alert = "Entertainment",
                Amount = "150"+ " USD",
                IconSource = "wallet.png",
            });
            masterPageItems.Add(new AlertDrawerItems
            {
                Alert = "Transport",
                Amount = "30" + " USD",
                IconSource = "wallet.png",
            });
            listView.ItemsSource = masterPageItems;


        }
        void addexpensefeed(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Splash());
        }
        async void InfiniteLoop() {
            while (true) {
                currentdate.Text = DateTime.Now.ToString("hh:mm:ss");
                double x= DateTime.Now.Hour * 0.1;
                if (x > 0.9)
                    x = 0.9;
               await progress.ProgressTo(x, 250, Easing.Linear);
                await Task.Delay(100);
            }
        }
    }
}
