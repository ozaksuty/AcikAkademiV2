
using Xamarin.Forms;

namespace AcikAkademiV2Ders2
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new CarouselViewPage());
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
