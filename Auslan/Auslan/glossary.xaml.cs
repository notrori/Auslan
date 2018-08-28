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
	public partial class glossary : ContentPage
	{
		public glossary ()
		{
			InitializeComponent ();
		}

        private void Alphabet(object sender, EventArgs e)
        {
            Navigation.PushAsync(new alphabet());
        }
    }
}