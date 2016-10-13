using Plugin.ScreenSize.Abstractions;
using System;
using Windows.UI.Xaml;

namespace Plugin.ScreenSize
{
    /// <summary>
    /// Implementation for Feature
    /// </summary>
    public class ScreenSizeImplementation : IScreenSize
    {
        public ScreenSizeHelper GetScreenSize()
        {
            ScreenSizeHelper helper = new ScreenSizeHelper
            {
                PlatformName = "UWP",
                ScreenHeight = Window.Current.Bounds.Height,
                ScreenWidth = Window.Current.Bounds.Width
            };

            return helper;
        }
    }
}