using Plugin.ScreenSize.Abstractions;
using System;
using System.Windows;

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
                PlatformName = "WinPhone8",
                ScreenHeight = Application.Current.Host.Content.ActualHeight,
                ScreenWidth = Application.Current.Host.Content.ActualWidth
            };

            return helper;
        }
    }
}