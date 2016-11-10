using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AcikAkademiV2Ders5.Localization
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        readonly CultureInfo ci = null;
        public string Text { get; set; }
        const string ResourceId = "AcikAkademiV2Ders5.Resx.AppResources";

        public TranslateExtension()
        {
            if (Device.OS == TargetPlatform.Android || 
                Device.OS == TargetPlatform.iOS)
            {
                ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            }
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
            {
                return "";
            }

            ResourceManager temp = new ResourceManager(ResourceId,
                typeof(TranslateExtension).GetTypeInfo().Assembly);

            var translation = temp.GetString(Text, ci);

            return translation;
        }
    }
}