using Xamarin.Forms;

namespace AcikAkademiV2Ders6.Models
{
    class PersonViewCell : ViewCell
    {
        public PersonViewCell()
        {
            Label lblName = new Label();
            lblName.SetBinding(Label.TextProperty, "Name");
            Label lblSurname = new Label();
            lblSurname.SetBinding(Label.TextProperty, "Surname");

            View = new StackLayout
            {
                Children =
                {
                    lblName, lblSurname
                }
            };
        }
    }
}