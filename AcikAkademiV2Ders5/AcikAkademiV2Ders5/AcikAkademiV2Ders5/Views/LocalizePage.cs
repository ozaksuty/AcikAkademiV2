using AcikAkademiV2Ders5.Resx;
using Xamarin.Forms;

namespace AcikAkademiV2Ders5.Views
{
    public class LocalizePage : ContentPage
    {
        public LocalizePage()
        {
            Button btnSave = new Button
            {
                Text = AppResources.Save
            };
            btnSave.Clicked += (s, e) =>
            {
                DisplayAlert(AppResources.SuccessPopupTitle,
                    AppResources.SuccessPopupMessage, AppResources.PopupButton);
            };
            Image imgIcon = new Image
            {
                Source = "Icon.png"
            };
            StackLayout layout = new StackLayout
            {
                Children =
                {
                    btnSave,
                    imgIcon
                }
            };
            TableView tView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot()
                {
                    new TableSection(AppResources.FormName)
                    {
                        new EntryCell
                        {
                            Label = AppResources.Name,
                            Keyboard = Keyboard.Default
                        },
                        new EntryCell
                        {
                            Label = AppResources.Surname,
                            Keyboard = Keyboard.Default
                        },
                        new EntryCell
                        {
                            Label = AppResources.Password,
                            Keyboard = Keyboard.Numeric
                        },
                        new ViewCell() { View = layout }
                    }
                }
            };

            Content = tView;
        }
    }
}