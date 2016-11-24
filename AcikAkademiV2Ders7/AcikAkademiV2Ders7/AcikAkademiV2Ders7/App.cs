using Xamarin.Forms;

namespace AcikAkademiV2Ders7
{
    public class App : Application
    {
        public App()
        {
            var content = new ContentPage
            {
                Title = "Push Notification",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Açık Akademi",
                            FontSize = 35
                        }
                    }
                }
            };

            MainPage = new NavigationPage(content);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
