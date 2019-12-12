using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; //for Stopwatch Class
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials; //for Vibrate on Tap


namespace SwimSetRandomiser
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Watch : ContentPage
	{
        Stopwatch stopwatch;

        public Watch()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();

            //default display
            labelStopwatch.Text = "00:00:00.00";

        }

        //Button Clicked events 
        #region  Method for starting the Timer..
        private void btnStart_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Or use specified time
                var duration = TimeSpan.FromSeconds(0.2);
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

           
            if (!stopwatch.IsRunning)
            {
                stopwatch.Start();

                //TimeSpan for 100 millisecond increments
                Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
                {
                    //Formatiing the Timer
                    TimeSpan ts = stopwatch.Elapsed;

                    labelStopwatch.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);

                    //Return Values
                    if (!stopwatch.IsRunning)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                );
            }
        }
        #endregion

        #region Method for Stopping the Timer..
        private void btnStop_Clicked(object sender, EventArgs e)
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
            btnStart.Text = "Resume";
            stopwatch.Stop();
        }
        #endregion

        #region Method for Reseting the Timer..
        private void btnReset_Clicked(object sender, EventArgs e)
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
            labelStopwatch.Text = "00:00:00.00";
            btnStart.Text = "Start";
            stopwatch.Reset();
        }
        #endregion


    }

}