using Plugin.LocalNotifications;
using System;
using Xamarin.Forms;

namespace AcikAkademiV2Ders3
{
    public partial class PluginPushNotification : ContentPage
    {
        public PluginPushNotification()
        {
            InitializeComponent();
            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
        }

        private void onSend(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string message = txtMessage.Text;

            CrossLocalNotifications.Current.Show(title, message);
        }
    }
}