using Plugin.Share;
using System;
using Xamarin.Forms;

namespace AcikAkademiV2Ders3
{
    public partial class PluginShare : ContentPage
    {
        public PluginShare()
        {
            InitializeComponent();
            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
        }

        private void onShare(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string message = txtMessage.Text;
            string url = txtUrl.Text;
            if (String.IsNullOrEmpty(url))
                url = "https://www.acikakademi.com";

            //CrossShare.Current.Share(message, title);
            CrossShare.Current.ShareLink("https://www.acikakademi.com/portal/_assets/img/logo.png", message, title);
            //CrossShare.Current.OpenBrowser(url, new Plugin.Share.Abstractions.BrowserOptions
            //{
            //    ChromeShowTitle = true,
            //    UseSafairReaderMode = true,
            //    UseSafariWebViewController = true
            //});
        }

        private void onCopy(object sender, EventArgs e)
        {
            if (CrossShare.Current.SupportsClipboard)
            {
                CrossShare.Current.SetClipboardText(txtTitle.Text);
                DisplayAlert(txtTitle.Text, "Kopyalandı!", "Ok");
            }
        }
    }
}
