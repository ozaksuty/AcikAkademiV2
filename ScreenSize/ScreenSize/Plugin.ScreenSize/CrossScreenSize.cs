using Plugin.ScreenSize.Abstractions;
using System;

namespace Plugin.ScreenSize
{
  /// <summary>
  /// Cross platform ScreenSize implemenations
  /// </summary>
  public class CrossScreenSize
  {
    static Lazy<IScreenSize> Implementation = new Lazy<IScreenSize>(() => CreateScreenSize(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

    /// <summary>
    /// Current settings to use
    /// </summary>
    public static IScreenSize Current
    {
      get
      {
        var ret = Implementation.Value;
        if (ret == null)
        {
          throw NotImplementedInReferenceAssembly();
        }
        return ret;
      }
    }

    static IScreenSize CreateScreenSize()
    {
#if PORTABLE
        return null;
#else
        return new ScreenSizeImplementation();
#endif
    }

    internal static Exception NotImplementedInReferenceAssembly()
    {
      return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
    }
  }
}
