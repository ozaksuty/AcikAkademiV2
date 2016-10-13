using Android.Content.Res;
using Plugin.ScreenSize.Abstractions;
using System;


namespace Plugin.ScreenSize
{
    /// <summary>
    /// Implementation for Feature
    /// </summary>
    public class ScreenSizeImplementation : IScreenSize
    {
        public ScreenSizeHelper GetScreenSize()
        {
            var metrics = Resources.System.DisplayMetrics;
            ScreenSizeHelper helper = new ScreenSizeHelper
            {
                PlatformName = "Android",
                ScreenHeight = ConvertPixelsToDp(metrics.HeightPixels),
                ScreenWidth = ConvertPixelsToDp(metrics.WidthPixels)
            };

            return helper;
        }

        private int ConvertPixelsToDp(int pixelValue)
        {
            var dp = (int)((pixelValue) / Resources.System.DisplayMetrics.Density);
            return dp;
        }
    }
}