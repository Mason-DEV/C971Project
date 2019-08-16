using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C971Project.CS;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Android.Content;

namespace C971Project.XAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            //Load settings
            loadSettings();
        }

        private void NotifcationToggle(object sender, ToggledEventArgs e)
        {
            Notifications.sendNotifcationNow();
            testToggle.On = false;
            
        }

        private void ThemeToggle_OnChanged(object sender, ToggledEventArgs e)
        {
            
            //if on set to dark
            if (themeToggle.On == true) {
                DisplayAlert("Dark", "Theme","Ok");
            }
            //else set to white
        }

        private void loadSettings()
        {
            if (Application.Current.Properties.ContainsKey("notifcationsSetting"))
            {
                notifcationToggle.On = (bool)Application.Current.Properties["notifcationsSetting"];

            }
        }

        private void NotifcationToggle_OnChanged(object sender, ToggledEventArgs e)
        {
            Application.Current.Properties["notifcationsSetting"] = notifcationToggle.On;

        }
    }
}