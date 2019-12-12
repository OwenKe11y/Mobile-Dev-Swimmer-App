using Java.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Xamarin.Essentials; //for Vibrate on Tap
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Random = System.Random; //For Random Value

namespace SwimSetRandomiser
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Randomiser : ContentPage
    {

        int clicked;

        public Randomiser()
        {
            InitializeComponent();

            //default display
            strokeRandom.Text = "";
        }

        private void Button_RandomClicked(object sender, EventArgs e)
        {
            #region Vibrate

            try
            {
                // Or use specified time
                var duration = TimeSpan.FromSeconds(0.05);
                Vibration.Vibrate(duration);
            }
            catch (FeatureNotSupportedException)
            {
                // Feature not supported on device
            }
            catch (Exception)
            {
                // Other error has occurred.
            }



            #endregion

            #region The String Array and Randomise method
            // string array
            string[] stringStroke = { "Freestyle", "Breaststroke", "Backcrawl", "Butterfly" };
            string[] stringDistance = { "50", "100", "150", "200", "250", "300" };
            string[] stringSets = { "3", "6", "9", "12", "15" };
            string[] stringStroke2 = { "Freestyle", "Breaststroke", "Backcrawl", "Butterfly" };
            string[] stringDistance2 = { "50", "100", "150", "200", "250", "300" };
            string[] stringSets2 = { "3", "6", "9", "12", "15" };
            string[] stringStroke3 = { "Freestyle", "Breaststroke", "Backcrawl", "Butterfly" };
            string[] stringDistance3 = { "50", "100", "150", "200", "250", "300" };
            string[] stringSets3 = { "3", "6", "9", "12", "15" };


            // init random generator
            Random rnd = new Random();
            Random rnd2 = new Random();
            Random rnd3 = new Random();


            // get random value 
            int r = rnd.Next(4);
            int r2 = rnd.Next(6);
            int r3 = rnd.Next(5);

            int rG1 = rnd2.Next(4);
            int rG2 = rnd2.Next(6);
            int rG3 = rnd2.Next(5);
            int rG4 = rnd3.Next(4);
            int rG5 = rnd3.Next(6);
            int rG6 = rnd3.Next(5);



            // pull out string from array
            string str = stringStroke[r];
            string str2 = stringDistance[r2];
            string str3 = stringSets[r3];

            string str4 = stringStroke2[rG1];
            string str5 = stringDistance2[rG2];
            string str6 = stringSets2[rG3];
            string str7 = stringStroke3[rG4];
            string str8 = stringDistance3[rG5];
            string str9 = stringSets3[rG6];


            // print string
            strokeRandom.Text = str;
            distanceRandom.Text = str2;
            setsRandom.Text = str3;
            strokeRandom2.Text = str4;
            distanceRandom2.Text = str5;
            setsRandom2.Text = str6;
            strokeRandom3.Text = str7;
            distanceRandom3.Text = str8;
            setsRandom3.Text = str9;
            #endregion
        }


            

        
        public void Addbutton(object sender, EventArgs args)
        {
            try
            {
                // Or use specified time
                var duration = TimeSpan.FromSeconds(0.05);
                Vibration.Vibrate(duration);
            }
            catch (FeatureNotSupportedException)
            {
                // Feature not supported on device
            }
            catch (Exception)
            {
                // Other error has occurred.
            }

            clicked++;

            if (clicked == 1)
            {
                AddOne.IsVisible = true;
            }

            if (clicked == 2)
            {
                AddTwo.IsVisible = true;
                AddBtn.IsVisible = false;
            }
       
        }


    }
}