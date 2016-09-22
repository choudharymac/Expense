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
       
        ObservableCollection<AlertDrawerItems> masterPageItems = new ObservableCollection<AlertDrawerItems>();
        public ExpenseDetail()
        {
            InitializeComponent();
            pickdate.DateSelected += Pickdate_DateSelected;
        }

        private void Pickdate_DateSelected(object sender, DateChangedEventArgs e)
        {
            //  temp.Text = "hii"+e.NewDate+"how"+pickdate.Date;   Alert = pickdate.Date.Day + "-" + pickdate.Date.Month + "-" + pickdate.Date.Year,

        }

        private void search( object sender, EventArgs args)
        {
            masterPageItems.Add(new AlertDrawerItems
            {
                Alert = "Electronics",
                Amount = "300 USD",
                IconSource = "wallet.png",
            });
            masterPageItems.Add(new AlertDrawerItems
            {
                Alert = "Transport",
                Amount = "20 USD",
                IconSource = "wallet.png",
            });
            masterPageItems.Add(new AlertDrawerItems
            {
                Alert = "Entertainment",
                Amount = "110 USD",
                IconSource = "wallet.png",
            });
            masterPageItems.Add(new AlertDrawerItems
            {
                Alert = "Stationary",
                Amount = "15 USD",
                IconSource = "wallet.png",
            });
            listView.ItemsSource = masterPageItems;
        }
        
    }
}
