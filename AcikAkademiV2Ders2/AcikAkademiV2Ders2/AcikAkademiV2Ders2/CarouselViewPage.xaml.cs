using System.Collections.Generic;
using Xamarin.Forms;

namespace AcikAkademiV2Ders2
{
    class ViewObject
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public partial class CarouselViewPage : ContentPage
    {
        List<ViewObject> model = new List<ViewObject>();
        public CarouselViewPage()
        {
            InitializeComponent();

            GenerateSampleData();

            CV.ItemsSource = model;
            CV.ItemSelected += CV_ItemSelected;
        }

        private async void CV_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedModel = (ViewObject)e.SelectedItem;
            var result = await DisplayAlert("Cat", "Url : " + selectedModel.Url, "Seç", "Vazgeç");
            if (result)
            {
                await Navigation.PushAsync(new MapPage());
            }
        }

        private void GenerateSampleData()
        {
            for (int i = 1; i <= 6; i++)
            {
                model.Add(new ViewObject
                {
                    Name = "Cat " + i,
                    Url = string.Format("http://www.ozaksut.com/cat/cat{0}.jpg", i)
                });
            }
        }
    }
}