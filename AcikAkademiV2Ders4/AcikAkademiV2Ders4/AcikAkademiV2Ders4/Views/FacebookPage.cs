using AcikAkademiV2Ders4.Models;
using AcikAkademiV2Ders4.Provider;
using System;
using Xamarin.Forms;

namespace AcikAkademiV2Ders4.Views
{
    //https://www.facebook.com/dialog/oauth?client_id=
    //1803262896589263&redirect_uri=
    //https://www.facebook.com/connect/login_success.html
    public class FacebookPage : ContentPage
    {
        private string FacebookClientId = "1803262896589263";
        public FacebookPage()
        {
            this.BackgroundColor = Color.White;

            var apiRequest =
                "https://www.facebook.com/dialog/oauth?client_id="
                + FacebookClientId
                + "&display=popup&response_type=token&redirect_uri=http://www.facebook.com/connect/login_success.html";

            var webView = new WebView
            {
                Source = apiRequest,
                HeightRequest = 1
            };

            webView.Navigated += WebView_Navigated;

            Content = webView;
        }

        private async void WebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            var accessToken = ExtractAccessTokemFromUrl(e.Url);

            if (!String.IsNullOrEmpty(accessToken))
            {
                ServiceManager<FacebookProfile> manager = new ServiceManager<FacebookProfile>();
                var profile = await manager.GetFacebookProfile(accessToken);
                SetFacebookProfile(profile);
            }
        }

        private void SetFacebookProfile(FacebookProfile profile)
        {
            Image profilePicture = new Image
            {
                Source = ImageSource.FromUri(new Uri(
                    "https://graph.facebook.com/" + profile.Id + "/picture?width=450&height=450"))
            };

            Label lblName = new Label
            {
                Text = profile.Name,
                FontSize = 24,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Black
            };

            StackLayout layout = new StackLayout
            {
                Padding = 10,
                Spacing = 10,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    profilePicture,
                    lblName
                }
            };

            Content = layout;
        }

        private string ExtractAccessTokemFromUrl(string uri)
        {
            if (uri.Contains("access_token") && uri.Contains("&expires_in="))
            {
                var http = "https";
                if (Xamarin.Forms.Device.OS == TargetPlatform.Windows || Xamarin.Forms.Device.OS == TargetPlatform.WinPhone)
                    http = "http";
                uri = uri.Replace(http + "://www.facebook.com/connect/login_success.html#access_token=", "");
                var accessToken = uri.Remove(uri.IndexOf("&expires_in="));
                return accessToken;
            }

            return "";
        }
    }
}