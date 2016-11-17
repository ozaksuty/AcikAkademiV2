using Xamarin.Forms;

namespace AcikAkademiV2Ders6.GestureSample
{
    public partial class PinchGesturePage : ContentPage
    {
        public PinchGesturePage()
        {
            InitializeComponent();

            //var scaleUp = new Button
            //{
            //    Text = "Scale Up!"
            //};

            //scaleUp.Clicked += (s, e) =>
            //{
            //    this.Scale += 1;
            //};

            //var scaleDown = new Button
            //{
            //    Text = "Scale Down!"
            //};

            //scaleDown.Clicked += (s, e) =>
            //{
            //    this.Scale -= 1;
            //};

            //Content = new StackLayout
            //{
            //    VerticalOptions = LayoutOptions.Center,
            //    Children =
            //    {
            //        scaleUp,
            //        scaleDown
            //    }
            //};

            Content = new Grid
            {
                Children =
                {
                    new PinchToZoomContainer
                    {
                        Content = new Image
                        {
                            Source = 
                            ImageSource.FromFile("monkey.jpg")
                        }
                    }
                }
            };
        }
    }
}
