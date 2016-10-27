using Plugin.Media;
using System;
using Xamarin.Forms;

namespace AcikAkademiV2Ders3
{
    public partial class PluginMedia : ContentPage
    {
        public PluginMedia()
        {
            InitializeComponent();
        }

        private async void onTakePhoto(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable ||
                !CrossMedia.Current.IsTakePhotoSupported)
            {
                DisplayAlert("Hata", "Kamera Kullanılamıyor!", "Tamam");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "Sample",
                Name = "photo.jpg"
            });

            if (file == null)
            {
                return;
            }

            image.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
        }

        private async void onPickPhoto(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                DisplayAlert("Hata", "Fotoğraf Seçimi Yapamazsınız!", "Tamam");
                return;
            }

            var file = await CrossMedia.Current.PickPhotoAsync();

            if (file == null)
            {
                return;
            }

            image.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
        }

        private async void onTakeVideo(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable || 
                !CrossMedia.Current.IsTakeVideoSupported)
            {
                DisplayAlert("Hata", "Video Çekimi Yapamazsınız!", "Tamam");
                return;
            }

            var file = await CrossMedia.Current.TakeVideoAsync(new Plugin.Media.Abstractions.StoreVideoOptions
            {
                Quality = Plugin.Media.Abstractions.VideoQuality.High,
                Directory = "SampleVideo",
                Name = "video.mp4"
            });

            if (file == null)
            {
                return;
            }

            file.Dispose();
        }

        private async void onPickVideo(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsPickVideoSupported)
            {
                DisplayAlert("Hata", "Video Seçimi Yapamazsınız!", "Tamam");
                return;
            }

            var file = await CrossMedia.Current.PickVideoAsync();

            if (file == null)
            {
                return;
            }
            //Set Video Player!!!

            file.Dispose();
        }
    }
}
