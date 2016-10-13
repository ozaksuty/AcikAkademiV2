using Plugin.ScreenSize;
using Xamarin.Forms;

namespace AcikAkademiV2Ders1
{
    public class App : Application
    {
        public App()
        {
            var result = CrossScreenSize.Current.GetScreenSize();
            var content = new ContentPage
            {
                Title = "AcikAkademiV2Ders1",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Platform : " + result.PlatformName
                        },
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Width : " + result.ScreenWidth
                        },
                        new Label
                        {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Height : " + result.ScreenHeight
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
