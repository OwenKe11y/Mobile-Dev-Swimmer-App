using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamarin.Essentials;

namespace SwimSetRandomiser
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : ContentPage
	{

		public Home ()
		{
			InitializeComponent ();
		}
	

        private void btnInfo_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("What is This?", "This App is designed to create random swim sets for your swim training.\n" +
                "The App also features a Stopwatch to time those sets and to track your improvement!", "Ok, I understand");

        }

     
        private void btnCred_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("What was used?","The main Plugins used to achive some features were:\n\n" +
                "Xamarin Essentials\n" +
                "Xamarin Diagnostics\n" +
                "Xamarin Forms\n"+
                "The main Resources used from the internet were:\n\n" +
                "StackOverflow\n" +
                "https://forums.xamarin.com/ \n" +
                "Microsoft and the offical Xamarin Forms Guides", "Alright");
        }
    }

}