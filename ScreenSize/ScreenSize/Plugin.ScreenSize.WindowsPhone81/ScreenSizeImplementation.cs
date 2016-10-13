using Plugin.ScreenSize.Abstractions;
using System;
using Windows.UI.Xaml;

namespace Plugin.ScreenSize
{
    /// <summary>
    /// Implementation for ScreenSize
    /// </summary>
    public class ScreenSizeImplementation : IScreenSize
    {
        public ScreenSizeHelper GetScreenSize()
        {
            ScreenSizeHelper helper = new ScreenSizeHelper
            {
                PlatformName = "WinPhone8.1",
                ScreenHeight = Window.Current.Bounds.Height,
                ScreenWidth = Window.Current.Bounds.Width
            };

            return helper;
        }
    }
}