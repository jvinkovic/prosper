using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prosper
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EarnMoney : ContentPage
	{
		public EarnMoney ()
		{
			InitializeComponent ();
		}
        void OnMowingSelect()
        {
            DisplayAlert("Mow The Lawn", "... awaiting implementation", "ok");
        }
        void OnCleanSelect()
        {
            DisplayAlert("Clean The House", "... awaiting implementation", "ok");
        }
        void OnTutorSelect()
        {
            DisplayAlert("Financial Tutor Game", "... awaiting implementation", "ok");
        }
        void OnCashierSelect()
        {
            DisplayAlert("Cashier Game", "... awaiting implementation", "ok");
        }
    }
}