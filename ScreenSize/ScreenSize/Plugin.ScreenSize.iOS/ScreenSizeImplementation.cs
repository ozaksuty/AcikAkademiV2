using Plugin.ScreenSize.Abstractions;
using UIKit;

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
                PlatformName = "iOS",
                ScreenWidth = UIScreen.MainScreen.Bounds.Width,
                ScreenHeight = UIScreen.MainScreen.Bounds.Height
            };

            return helper;
        }
    }
}