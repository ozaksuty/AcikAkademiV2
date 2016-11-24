Google Cloud Messaging (GCM) is a free service that enables developers to send messages between servers and client apps. This includes downstream messages from servers to client apps, and upstream messages from client apps to servers.

For example, a lightweight downstream message could inform a client app that there is new data to be fetched from the server, as in the case of a "new email" notification. For use cases such as instant messaging, a GCM message can transfer up to 4kb of payload to the client app. The GCM service handles all aspects of queueing of messages and delivery to and from the target client app.



Required Android API Levels
===========================

We recommend setting your app's *Target Framework* and *Target Android version* to **Android 5.0 (API Level 21)** or higher in your app project settings.

This Google Play Service SDK's requires a *Target Framework* of at least Android 4.1 (API Level 16) to compile.

You may still set a lower *Minimum Android version* (as low as Android 2.3 - API Level 9) so your app will run on older versions of Android, however you must ensure you do not use any API's at runtime that are not available on the version of Android your app is running on.




Google Developers Console Setup
=================================

Many of the Google Play Services SDK's require that you create an application inside the [Google Developers Console][1].  Visit the [Google Developers Console][1] to create a project for your application.

Once you have created a project for your Android app, enable the necessary APIs in the developer console for the Google Play Services APIs you will be using in your app.



To use the Google Cloud Messaging in your Android app, you must enable the *Cloud Messaging for Android* in the Google Developers Console, under *APIs and Auth*.



Android Manifest 
================

Some Google Play Services APIs require specific metadata, attributes, permissions or features to be declared in your *AndroidManifest.xml* file.

These can be added manually to the *AndroidManifest.xml* file, or merged in through the use of assembly level attributes.


It is **VERY** important that your application's package name does **NOT** start with an uppercase letter.  This will cause an error in deploying your application to a simulator or device.

Cloud Messaging requires the *Internet*, *WakeLock*, and *com.google.android.c2dm.permission.RECEIVE* permissions.  You can add these by adding the following code to your app (or manually adding them to your AndroidManifest.xml file):

```csharp
[assembly: UsesPermission ("com.google.android.c2dm.permission.RECEIVE")]
[assembly: UsesPermission (Android.Manifest.Permission.Internet)]
[assembly: UsesPermission (Android.Manifest.Permission.WakeLock)]
```

Cloud messaging also requires you to declare and use a special permission (`@PACKAGE_NAME@.permission.C2D_MESSAGE`) in your manifest file.  Again, you can either manually update your manifest file or add this code to your app:

```csharp
[assembly: Permission (Name="@PACKAGE_NAME@.permission.C2D_MESSAGE")]
[assembly: UsesPermission ("@PACKAGE_NAME@.permission.C2D_MESSAGE")]
```

Note that the `@PACKAGE_NAME@` is a special token that will be replaced with the actual package name of your application at build time.

Finally, you will need to declare the built-in GCM `BroadcastReceiver` in your manifest.  The easiest way to do this is to add a new .cs file to your project and paste the following code into it:

```csharp
using System;
using Android.Runtime;
using Android.App;
using Android.Content;

namespace Android.Gms.Gcm
{
    [BroadcastReceiver (
        Name="com.google.android.gms.gcm.GcmReceiver",
        Exported=true,
        Permission="com.google.android.c2dm.permission.SEND")]
    [IntentFilter (new [] { "com.google.android.c2dm.intent.RECEIVE", "com.google.android.c2dm.intent.REGISTRATION" }, 
        Categories = new [] { "@PACKAGE_NAME@" })]
    partial class GcmReceiver { }
}
```



Samples
=======

You can find a Sample Application within each Google Play Services component.  The sample will demonstrate the necessary configuration and some basic API usages.






Learn More
==========

You can learn more about the various Google Play Services SDKs & APIs by visiting the official [Google APIs for Android][3] documentation


You can learn more about Google Play Services GCM by visiting the official [Google Cloud Messaging for Android](https://developers.google.com/cloud-messaging/android/start) documentation.



[1]: https://console.developers.google.com/ "Google Developers Console"
[2]: https://developer.xamarin.com/guides/android/deployment,_testing,_and_metrics/MD5_SHA1/ "Finding your SHA-1 Fingerprints"
[3]: https://developers.google.com/android/ "Google APIs for Android"

