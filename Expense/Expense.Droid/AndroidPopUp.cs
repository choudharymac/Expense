using Android.App;
using Android.Widget;
using Expense;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidPopUp))]
namespace Expense
{
    public class AndroidPopUp : IAndroidPopUp
    {

        public void ShowToast(string message)
        {
            
            Toast.MakeText(Forms.Context, message, ToastLength.Long).Show();
        }
    }
}