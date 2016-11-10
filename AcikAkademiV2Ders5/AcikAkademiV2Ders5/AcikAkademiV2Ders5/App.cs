using AcikAkademiV2Ders5.Localization;
using AcikAkademiV2Ders5.Resx;
using AcikAkademiV2Ders5.Views;
using Xamarin.Forms;

namespace AcikAkademiV2Ders5
{
    public class App : Application
    {
        public App()
        {
            if (Device.OS == TargetPlatform.Android || 
                Device.OS == TargetPlatform.iOS)
            {
                DependencyService.Get<ILocalize>().SetLocale();
                AppResources.Culture = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            }
            MainPage = new LocalizePage();
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
