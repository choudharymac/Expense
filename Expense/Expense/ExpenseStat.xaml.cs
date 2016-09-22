using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Expense
{
    public partial class ExpenseStat : ContentPage
    {
        const int COUNT = 50; Random random = new Random();
        public ExpenseStat()
        {
            InitializeComponent();
            List<View> views = new List<View>(); TapGestureRecognizer tapGesture = new TapGestureRecognizer(); tapGesture.Tapped += OnBoxViewTapped;
            // Create BoxView elements and add to List.      
            for (int i = 0; i < COUNT; i++)
            {
                BoxView boxView = new BoxView
                {
                    Color = Color.Accent,
                    HeightRequest = 300 * random.NextDouble(),
                    VerticalOptions = LayoutOptions.End,
                    StyleId = RandomNameGenerator()
                };
                boxView.GestureRecognizers.Add(tapGesture); views.Add(boxView);
            }
            // Add whole List of BoxView elements to Grid.     
            grid.Children.AddHorizontal(views);
            // Start a timer at the frame rate.  
            Device.StartTimer(TimeSpan.FromMilliseconds(15), OnTimerTick);     }
        // Arrays for Random Name Generator.  
        string[] vowels = { "a", "e", "i", "o", "u", "ai", "ei", "ie", "ou", "oo" };
        string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m",
            "n", "p", "q", "r", "s", "t", "v", "w", "x", "z" };  
            string RandomNameGenerator()     {
                int numPieces = 1 + 2 * random.Next(1, 4); StringBuilder name = new StringBuilder();
                for (int i = 0; i < numPieces; i++) { name.Append(i % 2 == 0 ? consonants[random.Next(consonants.Length)] : vowels[random.Next(vowels.Length)]); }
                name[0] = Char.ToUpper(name[0]); return name.ToString();
            }
        // Set text to overlay Label and make it visible.  
        void OnBoxViewTapped(object sender, EventArgs args)
        {         BoxView boxView = (BoxView)sender;
            label.Text = String.Format("The Bar based on how " +            
                "much money you spend on an average",                                   
                boxView.StyleId, (int)boxView.HeightRequest);         overlay.Opacity = 1;     }
        // Decrease visibility of overlay.    
        bool OnTimerTick()     {         overlay.Opacity = Math.Max(0, overlay.Opacity - 0.0025);         return true;     } 
        }
    }

