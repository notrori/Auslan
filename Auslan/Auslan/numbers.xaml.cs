using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Octane.Xamarin.Forms.VideoPlayer;
using SQLite;
using System.IO;

namespace Auslan
{
    public partial class numbers : ContentPage
    {


        String number = " ";

        public numbers()
        {
            InitializeComponent();
        }

        public numbers (string numberInput)

        {
            InitializeComponent();
            number = numberInput;

            if (number == "1")
            {
                videoPlayer.Source = VideoSource.FromResource("Numbers - 1.mp4");
            }

            else if (number == "2")
            {
                videoPlayer.Source = VideoSource.FromResource("Numbers - 2.mp4");
            }

            else if (number == "3")
            {
                videoPlayer.Source = VideoSource.FromResource("Numbers - 3.mp4");
            }

            else if (number == "4")
            {
                videoPlayer.Source = VideoSource.FromResource("Numbers - 4.mp4");
            }

            else if (number == "5")
            {
                videoPlayer.Source = VideoSource.FromResource("Numbers - 5.mp4");
            }

            else if (number == "6")
            {
                videoPlayer.Source = VideoSource.FromResource("Numbers - 6.mp4");
            }

            else if (number == "7")
            {
                videoPlayer.Source = VideoSource.FromResource("Numbers - 7.mp4");
            }

            else if (number == "8")
            {
                videoPlayer.Source = VideoSource.FromResource("Numbers - 8.mp4");
            }
            else if (number == "9")
            {
                videoPlayer.Source = VideoSource.FromResource("Numbers - 9.mp4");
            }
        }



    }
}