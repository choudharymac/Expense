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
                Title = "Contacts",
                IconSource = "icon.png"
            });
            listView.ItemsSource = masterPageItems;
        }

    }

}
