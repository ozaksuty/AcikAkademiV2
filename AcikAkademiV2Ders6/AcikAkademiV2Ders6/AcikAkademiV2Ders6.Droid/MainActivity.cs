using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AcikAkademiV2Ders6.Droid
{
    [Activity(Label = "AcikAkademiV2Ders6", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            App.ScreenWidth = ConvertPixelsToDp(Resources.DisplayMetrics.WidthPixels);
            App.ScreenHeight = ConvertPixelsToDp(Resources.DisplayMetrics.HeightPixels);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }

        private int ConvertPixelsToDp(int pixelValue)
        {
            var dp = (int)((pixelValue / Resources.DisplayMetrics.Density));
            return dp;
        }
    }
}

