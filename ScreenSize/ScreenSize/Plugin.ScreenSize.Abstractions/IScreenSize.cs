using System;

namespace Plugin.ScreenSize.Abstractions
{
    /// <summary>
    /// Interface for ScreenSize
    /// </summary>
    public interface IScreenSize
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        ScreenSizeHelper GetScreenSize();
    }
}