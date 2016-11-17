using AcikAkademiV2Ders6.GestureSample;
using AcikAkademiV2Ders6.Messaging;
using Xamarin.Forms;

namespace AcikAkademiV2Ders6
{
    public class App : Application
    {
        public static int ScreenWidth { get; set; }
        public static int ScreenHeight { get; set; }
        public App()
        {
            MainPage = new TapGesturePage();
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
