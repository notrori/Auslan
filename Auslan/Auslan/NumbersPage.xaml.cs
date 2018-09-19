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
	public partial class NumbersPage : ContentPage
	{
		public NumbersPage ()
		{
			InitializeComponent ();
		}
        private void Number1(object sender, EventArgs e)
        {


            Navigation.PushAsync(new numbers("1"));
        }

        private void Number2(object sender, EventArgs e)
        {


            Navigation.PushAsync(new numbers("2"));
        }
        private void Number3(object sender, EventArgs e)
        {


            Navigation.PushAsync(new numbers("3"));
        }

        private void Number4(object sender, EventArgs e)
        {


            Navigation.PushAsync(new numbers("4"));
        }

        private void Number5(object sender, EventArgs e)
        {


            Navigation.PushAsync(new numbers("5"));
        }

        private void Number6(object sender, EventArgs e)
        {


            Navigation.PushAsync(new numbers("6"));
        }

        private void Number7(object sender, EventArgs e)
        {


            Navigation.PushAsync(new numbers("7"));
        }

        private void Number8(object sender, EventArgs e)
        {


            Navigation.PushAsync(new numbers("8"));
        }

        private void Number9(object sender, EventArgs e)
        {


            Navigation.PushAsync(new numbers("9"));
        }
    }
}