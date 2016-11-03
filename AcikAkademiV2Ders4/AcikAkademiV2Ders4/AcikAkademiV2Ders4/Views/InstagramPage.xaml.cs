using AcikAkademiV2Ders4.Models;
using AcikAkademiV2Ders4.Provider;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AcikAkademiV2Ders4.Views
{
    public partial class InstagramPage : ContentPage
    {
        private readonly IList<Item> model =
            new ObservableCollection<Item>();
        public InstagramPage()
        {
            InitializeComponent();
            BindingContext = model;
            GetProfile();
        }

        private async void GetProfile()
        {
            ServiceManager<InstagramProfile> manager =
                new ServiceManager<InstagramProfile>();

            var profile = await manager.Get("https://www.instagram.com/microsoft/media/");
            foreach (var item in profile.items)
                model.Add(item);
        }
    }
}
