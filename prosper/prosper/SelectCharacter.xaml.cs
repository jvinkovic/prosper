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
	public partial class SelectCharacter : ContentPage
	{
		public SelectCharacter ()
		{
			InitializeComponent ();
		}
        async void OnChar1Selection(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            button.IsEnabled = false;
            //create game object
            //set character to char 1
            Game game = new Game(1);
            //open my room
            await Navigation.PushAsync(new MyRoom());
        }
        async void OnChar2Selection(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            button.IsEnabled = false;
            //create game object
            //set character to char 2
            Game game = new Game(2);
            await Navigation.PushAsync(new MyRoom());
            //open my room
        }
        async void OnChar3Selection(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            button.IsEnabled = false;
            //create game object
            //set character to char 3
            Game game = new Game(3);
            //open my room
            //App.Current.MainPage = new NavigationPage(new MyRoom());
            //App.Current.MainPage.Navigation.PushAsync(new MyRoom());
            //await App.Current.MainPage.Navigation.PushAsync(new MyRoom());
            await Navigation.PushAsync(new MyRoom());
            //NavigationPage myRoom = new NavigationPage(new MyRoom());
            /// await start tutorial
        }
    }
}