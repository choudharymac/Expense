using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Expense
{
    public partial class ExpenseDetail : ContentPage
    {
        public ListView ListView { get { return listView; } }
        int i = 0;

       
        public ExpenseDetail()
        {
            InitializeComponent();
            pickdate.DateSelected += Pickdate_DateSelected;
        }

        private void Pickdate_DateSelected(object sender, DateChangedEventArgs e)
        {
            //  temp.Text = "hii"+e.NewDate+"how"+pickdate.Date;   Alert = pickdate.Date.Day + "-" + pickdate.Date.Month + "-" + pickdate.Date.Year,
            i = 0;

        }

        private void search(object sender, EventArgs args)
        {
            if (i == 0)
            {
                Random r = new Random();
                String[] cat = { " Stationary", " Food ", " Bills ", "Clothing ", "Groceries ", " Entertainment ", " Transport ", "Phone ", "Electronics " };
                ObservableCollection<AlertDrawerItems> masterPageItems = new ObservableCollection<AlertDrawerItems>();

                masterPageItems.Add(new AlertDrawerItems
                {
                    Alert = cat[r.Next(0, 8)],
                    Amount = r.Next(0,700)+" USD",
                    IconSource = "wallet.png",
                });
                masterPageItems.Add(new AlertDrawerItems
                {
                    Alert = cat[r.Next(0, 8)],
                    Amount = r.Next(0, 700) + " USD",
                    IconSource = "wallet.png",
                });
                masterPageItems.Add(new AlertDrawerItems
                {
                    Alert = cat[r.Next(0, 8)],
                    Amount = r.Next(0, 700) + " USD",
                    IconSource = "wallet.png",
                });
                masterPageItems.Add(new AlertDrawerItems
                {
                    Alert = cat[r.Next(0, 8)],
                    Amount = r.Next(0, 700) + " USD",
                    IconSource = "wallet.png",
                });
                listView.ItemsSource = masterPageItems;
                i = 1;
            }

            else
            {
                i = 1;
                if (Device.OS == TargetPlatform.Android)
                {
                    DependencyService.Get<IAndroidPopUp>().ShowToast("No more Results");
                }
            }
        }
    }
}
