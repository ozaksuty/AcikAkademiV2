
using Xamarin.Forms;

namespace AcikAkademiV2Ders6.GestureSample
{
    public partial class PanGesturePage : ContentPage
    {
        public PanGesturePage()
        {
            InitializeComponent();

            Content = new AbsoluteLayout
            {
                Children =
                {
                    new PanContainer
                    {
                        Content = new Image
                        {
                            Source = ImageSource.FromFile("monkey.jpg"),
                            WidthRequest = 1600,
                            HeightRequest = 1200
                        }
                    }
                }
            };
        }
    }
}
