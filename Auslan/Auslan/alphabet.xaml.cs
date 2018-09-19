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
	public partial class alphabet : ContentPage
	{

        

        public alphabet()
		{
			InitializeComponent ();

            

        }

        private void LetterA(object sender, EventArgs e)
        {
           
            
            Navigation.PushAsync(new letters("a"));
        }

        private void LetterB(object sender, EventArgs e)

        {
            
            Navigation.PushAsync(new letters("b"));
        }

        private void LetterC(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("c"));
        }

        private void LetterD(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("d"));
        }

        private void LetterE(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("e"));
        }

        private void LetterF(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("f"));
        }
        private void LetterG(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("g"));
        }

        private void LetterH(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("h"));
        }

        private void LetterI(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("i"));
        }

        private void LetterJ(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("j"));
        }

        private void LetterK(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("k"));
        }

        private void LetterL(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("l"));
        }

        private void LetterM(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("m"));
        }

        private void LetterN(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("n"));
        }

        private void LetterO(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("o"));
        }

        private void LetterP(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("p"));
        }

        private void LetterQ(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("q"));
        }

        private void LetterR(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("r"));
        }
        private void LetterS(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("s"));
        }
        private void LetterT(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("t"));
        }

        private void LetterU(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("u"));
        }

        private void LetterV(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("v"));
        }

        private void LetterW(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("w"));
        }
        private void LetterX(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("x"));
        }

        private void LetterY(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("y"));
        }

        private void LetterZ(object sender, EventArgs e)

        {

            Navigation.PushAsync(new letters("z"));
        }




    }
    }
