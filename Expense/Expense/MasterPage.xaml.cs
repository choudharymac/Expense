using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Expense
{
    public partial class MasterPage : ContentPage
    {
        
        public ListView ListView { get { return listView; } }

        public MasterPage()
        {

            InitializeComponent();
           
            var masterPageItems = new List<DrawerItem>();
           
            masterPageItems.Add(new DrawerItem
            {
                Title = "Current Feeds",
                IconSource = "dashboard.png",
                TargetType = typeof(Feed)
            });
           masterPageItems.Add(new DrawerItem
            {
                Title = "Expense Details",
                IconSource = "check.png"
           });
            masterPageItems.Add(new DrawerItem
            {
                Title = "Add Expense",
                IconSource = "add.png"
            });
            masterPageItems.Add(new DrawerItem
            {
                Title = "Cash Wallet",
                IconSource = "wallet.png"
            });
            masterPageItems.Add(new DrawerItem
            {
                Title = "Categories",
               IconSource = "category.png"
            });
            masterPageItems.Add(new DrawerItem
            {
                Title = "Expense Stats",
                IconSource = "expense.png"
            });
            masterPageItems.Add(new DrawerItem
            {
                Title = "Set Alert",
                IconSource = "warning.png"
            });
            masterPageItems.Add(new DrawerItem
            {
                Title = "Compare Expense",
                IconSource = "comparison.png"
            });
            listView.ItemsSource = masterPageItems;
        }

    }

}
