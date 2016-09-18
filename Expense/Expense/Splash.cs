using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Expense
{
    public class Splash : ContentPage
    {
        public Splash()
        {
            Button skip = new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Xamarin.Forms.Color.Aqua,
                Text = "Skip to proceed",
                TextColor = Xamarin.Forms.Color.White,
                VerticalOptions = LayoutOptions.End
            };
            skip.Clicked += OnButtonClicked;

            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                InputTransparent = true,

                Children = {
                     new Label { Text = "Expense Manager",
                    HorizontalOptions = LayoutOptions.Center,
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                         FontAttributes = FontAttributes.Bold ,
                    VerticalOptions = LayoutOptions.Start
                    },
                  new Image {
                    HorizontalOptions = LayoutOptions.Center,
                      VerticalOptions = LayoutOptions.Center,
                     Source="monitor.png"
                  },
                     skip
                }

            };
            Padding = Device.OnPlatform<Thickness>(new Thickness(20, 100, 20, 20), new Thickness(0), new Thickness(0));

        }

    async void OnButtonClicked(object sender, EventArgs args)
        {         // Add Label to scrollable StackLayout.         
            await Navigation.PushModalAsync(new Login());
        }
    }
}
