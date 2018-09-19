using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Auslan
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetingsMenu : ContentPage
	{
		public GreetingsMenu ()
		{
			InitializeComponent ();
		}

        private void Bad(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Greeting("Bad"));
        }
        private void Fabulous(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Greeting("Fabulous"));
        }
        private void FeelingGood(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Greeting("FeelingGood"));
        }
        private void Good(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Greeting("Good"));
        }
        private void GoodBye(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Greeting("GoodBye"));
        }
        private void Great(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Greeting("Great"));
        }
        private void Happy(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Greeting("Happy"));
        }
        private void Hello(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Greeting("Hello"));
        }
        private void HowAreYou(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Greeting("HowAreYou"));
        }
        private void Name(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Greeting("Name"));
        }
        private void NiceToMeetYou(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Greeting("NiceToMeetYou"));
        }
        private void Sad(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Greeting("Sad"));
        }
        private void SeeYouLater(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Greeting("SeeYouLater"));
        }
        private void Sick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Greeting("Sick"));
        }
        private void Tired(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Greeting("Tired"));
        }
        private void Welcome(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Greeting("Welcome"));
        }
    }
}