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
    public partial class letters : ContentPage
    {


        String letter = " ";

        public letters()
        {
            InitializeComponent();
        }

        public letters(string letterInput)

        {
            InitializeComponent();
            letter = letterInput;
           
            if (letter == "a")
            {

               

                videoPlayer.Source = VideoSource.FromResource("Alphabet - A.mp4"); }
            else if (letter == "b")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - B.mp4"); }
            else if (letter == "c")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - C.mp4"); }
            else if (letter == "d")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - D.mp4"); }
            else if (letter == "e")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - E.mp4"); }
            else if (letter == "f")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - F.mp4"); }
            else if (letter == "g")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - G.mp4"); }
            else if (letter == "h")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - H.mp4"); }
            else if (letter == "i")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - I.mp4"); }
            else if (letter == "j")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - J.mp4"); }
            else if (letter == "k")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - K.mp4"); }
            else if (letter == "l")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - L.mp4"); }
            else if (letter == "m")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - M.mp4"); }
            else if (letter == "n")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - N.mp4"); }
            else if (letter == "o")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - O.mp4"); }
            else if (letter == "p")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - P.mp4"); }
            else if (letter == "q")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - Q.mp4"); }
            else if (letter == "r")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - R.mp4"); }
            else if (letter == "s")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - S.mp4"); }
            else if (letter == "t")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - T.mp4"); }
            else if (letter == "u")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - U.mp4"); }
            else if (letter == "v")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - V.mp4"); }
            else if (letter == "w")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - W.mp4"); }
            else if (letter == "x")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - X.mp4"); }
            else if (letter == "y")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - Y.mp4"); }
            else if (letter == "z")
            { videoPlayer.Source = VideoSource.FromResource("Alphabet - Z.mp4"); }
        }



    }
}