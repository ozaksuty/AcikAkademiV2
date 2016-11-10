using System.Globalization;

namespace AcikAkademiV2Ders5.Localization
{
    public interface ILocalize
    {
        void SetLocale();
        CultureInfo GetCurrentCultureInfo();
    }
}