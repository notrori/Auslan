using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octane.Xamarin.Forms.VideoPlayer;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Auslan
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Greeting : ContentPage
	{
		public Greeting ()
		{
			InitializeComponent ();
		}

        public Greeting(string greetingInput)

        {
            InitializeComponent();
            string greeting = greetingInput;

            if (greeting == "Bad")
            {
                videoPlayer.Source = VideoSource.FromResource("Greetings - Bad.mp4");
            }

            else if (greeting == "Fabulous")
            {
                videoPlayer.Source = VideoSource.FromResource("Greetings - Fabulous.mp4");
            }
            else if (greeting == "FeelingGood")
            {
                videoPlayer.Source = VideoSource.FromResource("Greetings - Feeling Good.mp4");
            }
            else if (greeting == "Good")
            {
                videoPlayer.Source = VideoSource.FromResource("Greetings - Good.mp4");
            }
            else if (greeting == "GoodBye")
            {
                videoPlayer.Source = VideoSource.FromResource("Greetings - Goodbye.mp4");
            }
            else if (greeting == "Great")
            {
                videoPlayer.Source = VideoSource.FromResource("Greetings - Great.mp4");
            }
            else if (greeting == "Happy")
            {
                videoPlayer.Source = VideoSource.FromResource("Greetings - Happy.mp4");
            }
            else if (greeting == "Hello")
            {
                videoPlayer.Source = VideoSource.FromResource("Greetings - Hello.mp4");
            }
            else if (greeting == "HowAreYou")
            {
                videoPlayer.Source = VideoSource.FromResource("Greetings - How Are You.mp4");
            }
            else if (greeting == "Name")
            {
                videoPlayer.Source = VideoSource.FromResource("Greetings - Name.mp4");
            }
            else if (greeting == "NiceToMeetYou")
            {
                videoPlayer.Source = VideoSource.FromResource("Greetings - Nice To Meet You.mp4");
            }
            else if (greeting == "Sad")
            {
                videoPlayer.Source = VideoSource.FromResource("Greetings - Sad.mp4");
            }
            else if (greeting == "SeeYouLater")
            {
                videoPlayer.Source = VideoSource.FromResource("Greetings - See You Later.mp4");
            }
            else if (greeting == "Sick")
            {
                videoPlayer.Source = VideoSource.FromResource("Greetings - Sick.mp4");
            }
            else if (greeting == "Tired")
            {
                videoPlayer.Source = VideoSource.FromResource("Greetings - Tired.mp4");
            }
            else if (greeting == "Welcome")
            {
                videoPlayer.Source = VideoSource.FromResource("Greetings - Welcome.mp4");
            }
        }

    }
}