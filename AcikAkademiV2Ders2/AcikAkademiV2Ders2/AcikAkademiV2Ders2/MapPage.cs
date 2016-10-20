using Plugin.Geolocator;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace AcikAkademiV2Ders2
{
    public class MapPage : ContentPage
    {
        private double Latitude;
        private double Longitude;
        public MapPage()
        {
            //CreateMap();
            GetLocation();
        }

        private async void GetLocation()
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            var position = await locator.GetPositionAsync(timeoutMilliseconds: 10000);

            Latitude = position.Latitude;
            Longitude = position.Longitude;

            CreateMap();
        }

        void CreateMap()
        {
            Map currentMap = new Map
            {
                HasScrollEnabled = true,
                HasZoomEnabled = true,
                MapType = MapType.Street,
                IsShowingUser = true
            };

            Pin microsoftPin = new Pin
            {
                Type = PinType.Place,
                Address = "Microsoft Türkiye İstanbul",
                Label = "Microsoft Türkiye",
                Position = new Position(41.0707118, 29.0154514)
            };

            Pin pin2 = new Pin
            {
                Type = PinType.Place,
                Address = "Açık Akademi İstanbul",
                Label = "Açık Akademi",
                Position = new Position(41.0703419, 29.0158065)
            };

            microsoftPin.Clicked += MicrosoftPin_Clicked;
            pin2.Clicked += MicrosoftPin_Clicked;

            currentMap.Pins.Add(microsoftPin);
            currentMap.Pins.Add(pin2);

            currentMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(Latitude, Longitude), Distance.FromMeters(250)));

            Content = currentMap;
        }

        private void MicrosoftPin_Clicked(object sender, EventArgs e)
        {
            Pin selectedPin = (Pin)sender;
            DisplayAlert(selectedPin.Label, selectedPin.Address, "Ok");
        }
    }
}