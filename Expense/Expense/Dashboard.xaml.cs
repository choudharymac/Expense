using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Expense
{
    public partial class Dashboard : MasterDetailPage
    {
        public Dashboard()
        {
            InitializeComponent();
            masterPage.ListView.ItemSelected += OnItemSelected;
        }
        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as DrawerItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
