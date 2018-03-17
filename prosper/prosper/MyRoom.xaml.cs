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
	public partial class MyRoom : ContentPage
	{
        public Game game = Game.Instance;
		public MyRoom ()
		{
            InitializeComponent ();
         }
        void OnRandomSelect()
        {
            //display a content view
            DisplayAlert("Random Event", "This RANDOM thing HAPPENED", "ok");
        }
        void OnShopSelect()
        {
            //show a new page
            DisplayAlert("Shop", "This is when the shop will display... awaiting implementation", "ok");
        }

        async void OnEarnMoneySelect()
        {

            await Navigation.PushAsync(new EarnMoney());
        }
        async void OnManageMoneySelect()
        {
            await Navigation.PushAsync(new ManageMoney());
        }


        





    }
}