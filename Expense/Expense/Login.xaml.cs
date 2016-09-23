using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Expense
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            titleLabel.TextColor = Color.FromHex("#469978");
            titleLabel.HorizontalOptions = LayoutOptions.Start;
            titleLabel.VerticalOptions = LayoutOptions.Center;
            displayLabel.Text = "";
            titleLabel.FontAttributes= FontAttributes.Bold;
           
           

        }
        private void OnBackspaceButtonClicked(object sender, EventArgs e)
        {
            if(displayLabel.Text.Length>1)
            displayLabel.Text = displayLabel.Text.Remove(displayLabel.Text.Length - 1);
           else if (displayLabel.Text.Length==1)
                displayLabel.Text = "";

        }
        private void OnDigitButtonClicked(object sender, EventArgs e)
        {
            if (displayLabel.Text.Equals("Failure"))
            {
                displayLabel.Text = "";
                displayLabel.Text = displayLabel.Text + (sender as Button).Text;
            }else
            if (displayLabel.Text.Length <4)
                displayLabel.Text = displayLabel.Text + (sender as Button).Text;
           
        }
        private void OnValidateClicked(object sender, EventArgs e)
        {
            if ((sender as Button).Text.Equals("OK") && displayLabel.Text.Equals("1234"))
            {
                displayLabel.Text = "Success";
                Navigation.PushModalAsync(new Dashboard());
            }
            else
                 if (Device.OS == TargetPlatform.Android)
            {
                DependencyService.Get<IAndroidPopUp>().ShowToast("Wrong Passcode");
            }
        }
    }
    
}
