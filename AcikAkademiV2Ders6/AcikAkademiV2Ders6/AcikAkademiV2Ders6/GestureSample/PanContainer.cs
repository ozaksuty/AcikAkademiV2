using System;
using Xamarin.Forms;

namespace AcikAkademiV2Ders6.GestureSample
{
    public class PanContainer : ContentView
    {
        double x, y;
        public PanContainer()
        {
            var panGesture = new PanGestureRecognizer();
            panGesture.PanUpdated += PanGesture_PanUpdated;
            this.GestureRecognizers.Add(panGesture);
        }

        private void PanGesture_PanUpdated(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Running:
                    Content.TranslationX =
                        Math.Max(Math.Min(0, x + e.TotalX),
                        -Math.Abs(Content.Width - App.ScreenWidth));
                    Content.TranslationY =
                        Math.Max(Math.Min(0, y + e.TotalY),
                        -Math.Abs(Content.Height - App.ScreenHeight));
                    break;
                case GestureStatus.Completed:
                    x = Content.TranslationX;
                    y = Content.TranslationY;
                    break;
            }
        }
    }
}