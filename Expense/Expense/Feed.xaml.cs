using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Expense
{
    public partial class Feed : ContentPage
    {
        public Feed()
        {
            InitializeComponent();
            InfiniteLoop();
            totalamount.Text = "AUD " + "200";
            moneyspend.Text = "AUD " + "20";
            

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
