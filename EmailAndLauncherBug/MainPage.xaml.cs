using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace EmailAndLauncherBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Email_1_Tapped(Object sender, EventArgs e)
        {
            try
            {
                Email.ComposeAsync(null, null, "rrt@we-worldwide.com");
            }
            catch (FeatureNotSupportedException ex)
            {
                Console.WriteLine("Email not supported on this device. Exception: " + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Other exception: " + ex);
            }
        }

        void Email_2_Tapped(Object sender, EventArgs e)
        {
            try
            {
                Launcher.OpenAsync("mailto:xboxpress@assemblyinc.com");
            }
            catch (FeatureNotSupportedException ex)
            {
                Console.WriteLine("Launcher not supported on this device. Exception: " + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Other exception: " + ex);
            }
        }
    }
}
