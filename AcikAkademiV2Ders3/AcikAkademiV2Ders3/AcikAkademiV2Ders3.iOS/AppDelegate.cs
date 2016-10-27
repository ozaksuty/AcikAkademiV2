using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace AcikAkademiV2Ders3.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            var settings = UIUserNotificationSettings.GetSettingsForTypes(
                    UIUserNotificationType.Alert | UIUserNotificationType.Badge |
                    UIUserNotificationType.Sound, new NSSet());

            UIApplication.SharedApplication.RegisterUserNotificationSettings(settings);

            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }

        public override void ReceivedLocalNotification(UIApplication application, UILocalNotification notification)
        {
            if (UIApplication.SharedApplication.ApplicationState == UIApplicationState.Active)
            {
                //new UIAlertView(notification.AlertAction, notification.AlertBody, null, "Ok", null).Show();
                var alert = UIAlertController.Create(notification.AlertAction, notification.AlertBody, UIAlertControllerStyle.ActionSheet);
                UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(alert, true, null);
            }
        }
    }
}
