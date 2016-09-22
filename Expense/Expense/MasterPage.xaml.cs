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
                IconSource = "check.png",
                TargetType = typeof(ExpenseDetail)
            });
            masterPageItems.Add(new DrawerItem
            {
                Title = "Add Expense",
                IconSource = "add.png",
                TargetType = typeof(AddExpense)
            });
            masterPageItems.Add(new DrawerItem
            {
                Title = "Cash Wallet",
                IconSource = "wallet.png",
                TargetType = typeof(CashWallet)
            });
            masterPageItems.Add(new DrawerItem
            {
                Title = "Categories",
               IconSource = "category.png",
                TargetType = typeof(Category)
            });
            masterPageItems.Add(new DrawerItem
            {
                Title = "Expense Stats",
                IconSource = "expense.png",
                TargetType = typeof(ExpenseStat)
            });
            masterPageItems.Add(new DrawerItem
            {
                Title = "Set Alert",
                IconSource = "warning.png",
                TargetType = typeof(SetAlert)
            });
            masterPageItems.Add(new DrawerItem
            {
                Title = "About Us",
                IconSource = "info.png",
                TargetType = typeof(Compare)
            });
            listView.ItemsSource = masterPageItems;
        }

    }

}
