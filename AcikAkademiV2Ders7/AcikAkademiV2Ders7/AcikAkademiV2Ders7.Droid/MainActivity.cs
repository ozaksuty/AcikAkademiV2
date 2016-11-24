using Android.App;
using Android.Content.PM;
using Android.OS;
using Com.OneSignal;
using System.Collections.Generic;

namespace AcikAkademiV2Ders7.Droid
{
    [Activity(Label = "AcikAkademiV2Ders7", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            // Notification Receive Delegate
            OneSignal.NotificationReceived exampleNotificationReceivedDelegate = delegate (OSNotification notification)
            {
                try
                {
                    System.Console.WriteLine("OneSignal Notification Received:\nMessage: {0}", notification.payload.body);
                    Dictionary<string, object> additionalData = notification.payload.additionalData;

                    if (additionalData.Count > 0)
                        System.Console.WriteLine("additionalData: {0}", additionalData);
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine(e.StackTrace);
                }
            };

            // Notification Opened Delegate
            OneSignal.NotificationOpened exampleNotificationOpenedDelegate = delegate (OSNotificationOpenedResult result)
            {
                try
                {
                    System.Console.WriteLine("OneSignal Notification opened:\nMessage: {0}", result.notification.payload.body);
                    Dictionary<string, object> additionalData = result.notification.payload.additionalData;
                    if (additionalData.Count > 0)
                        System.Console.WriteLine("additionalData: {0}", additionalData);


                    List<Dictionary<string, object>> actionButtons = result.notification.payload.actionButtons;
                    if (actionButtons.Count > 0)
                        System.Console.WriteLine("actionButtons: {0}", actionButtons);
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine(e.StackTrace);
                }
            };

            // Initialize OneSignal
            OneSignal.StartInit("f8b5ffe8-33e3-47de-b0bc-c7fe05325f80",
                "211973902557")
              .HandleNotificationReceived(exampleNotificationReceivedDelegate)
              .HandleNotificationOpened(exampleNotificationOpenedDelegate)
              .EndInit();

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}