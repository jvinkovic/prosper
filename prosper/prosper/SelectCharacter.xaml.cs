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
        void OnChar1Tap(object sender, EventArgs args)
        {
            //make button visible
            char1Button.IsVisible = true;
            //change grid background colour
            Char1Border.BackgroundColor = Color.WhiteSmoke;
            //make other buttons invisibible
            char2Button.IsVisible = false;
            char3Button.IsVisible = false;
            //change other grid background colours
            Char2Border.BackgroundColor = Color.LightSlateGray;
            Char3Border.BackgroundColor = Color.LightSlateGray;
        }
        void OnChar2Tap(object sender, EventArgs args)
        {
            //make button visible
            char2Button.IsVisible = true;
            //change grid background colour
            Char2Border.BackgroundColor = Color.WhiteSmoke;
            //make other buttons invisibible
            char1Button.IsVisible = false;
            char3Button.IsVisible = false;
            //change other grid background colours
            Char1Border.BackgroundColor = Color.LightSlateGray;
            Char3Border.BackgroundColor = Color.LightSlateGray;
        }
        void OnChar3Tap(object sender, EventArgs args)
        {
            //make button visible
            char3Button.IsVisible = true;
            //change grid background colour
            Char3Border.BackgroundColor = Color.WhiteSmoke;
            //make other buttons invisibible
            char2Button.IsVisible = false;
            char1Button.IsVisible = false;
            //change other grid background colours
            Char2Border.BackgroundColor = Color.LightSlateGray;
            Char1Border.BackgroundColor = Color.LightSlateGray;
        }
        async void OnChar1Selection(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            //create game object
            //set character to char 1
            Game game = new Game(1);
            //open my room
            await Navigation.PushAsync(new MyRoom(game));
        }
        async void OnChar2Selection(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            //create game object
            //set character to char 2
            Game game = new Game(2);
            await Navigation.PushAsync(new MyRoom(game));
            //open my room
        }
        async void OnChar3Selection(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            //create game object
            //set character to char 3
            Game game = new Game(3);
            //open my room
            //App.Current.MainPage = new NavigationPage(new MyRoom());
            //App.Current.MainPage.Navigation.PushAsync(new MyRoom());
            //await App.Current.MainPage.Navigation.PushAsync(new MyRoom());
            await Navigation.PushAsync(new MyRoom(game));
            //NavigationPage myRoom = new NavigationPage(new MyRoom());
            /// await start tutorial
        }
    }
}