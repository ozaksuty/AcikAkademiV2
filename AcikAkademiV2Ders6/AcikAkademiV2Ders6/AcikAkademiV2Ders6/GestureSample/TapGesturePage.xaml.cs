using Xamarin.Forms;

namespace AcikAkademiV2Ders6.GestureSample
{
    public partial class TapGesturePage : ContentPage
    {
        int tapCount = 0;
        Label lblTap;
        public TapGesturePage()
        {
            InitializeComponent();

            lblTap = new Label
            {
                TextColor = Color.Black,
                FontSize = 48
            };

            var image = new Image
            {
                Source = "monkey.jpg",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var tapGestureRecognizer = new TapGestureRecognizer();
            //tapGestureRecognizer.NumberOfTapsRequired = 2;
            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
            image.GestureRecognizers.Add(tapGestureRecognizer);

            Content = new StackLayout
            {
                Children =
                {
                    image,
                    lblTap
                }
            };
        }

        private async void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            tapCount++;
            lblTap.Text = tapCount.ToString();

            var imageSender = (Image)sender;

            if (tapCount % 2 == 0)
            {
                await imageSender.ScaleTo(1, 2500, Easing.SinIn);
                await imageSender.RotateTo(180, 1000, Easing.BounceOut);
                await imageSender.FadeTo(1, 500, Easing.SpringIn);
            }
            else
            {
                await imageSender.ScaleTo(0.50, 2500, Easing.SinOut);
                await imageSender.RotateXTo(180, 1000, Easing.CubicOut);
                await imageSender.FadeTo(0.6, 500, Easing.CubicInOut);
            }

            //TranslateTo animates the TranslationX and TranslationY properties of a VisualElement.
            //ScaleTo animates the Scale property of a VisualElement.
            //RelScaleTo applies an animated incremental increase or decrease to the Scale property of a VisualElement.
            //RotateTo animates the Rotation property of a VisualElement.
            //RelRotateTo applies an animated incremental increase or decrease to the Rotation property of a VisualElement.
            //RotateXTo animates the RotationX property of a VisualElement.
            //RotateYTo animates the RotationY property of a VisualElement.
            //FadeTo animates the Opacity property of a VisualElement.
        }
    }
}
