using AcikAkademiV2Ders4.Provider;
using Acr.UserDialogs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AcikAkademiV2Ders4.Views
{
    public partial class TwitterPage : ContentPage
    {
        private readonly IList<Tweets> model = new
            ObservableCollection<Tweets>();
        TweetManager manager = new TweetManager();
        public TwitterPage()
        {
            InitializeComponent();
            BindingContext = model;
        }

        private async Task BindHashtag(string twitter)
        {
            UserDialogs.Instance.ShowLoading("Loading hashtag..", MaskType.Gradient);
            model.Clear();
            var hashtagresult = await manager.GetHashTagData(twitter);
            foreach (var item in hashtagresult)
                model.Add(item);
            UserDialogs.Instance.HideLoading();
        }

        private async void onGetHashtag(object sender, EventArgs e)
        {
            await BindHashtag(txtTwitter.Text);
        }

        private async Task BindTweets(string user)
        {
            UserDialogs.Instance.ShowLoading("Loading Tweets...", MaskType.Gradient);
            model.Clear();
            var tweets = await manager.GetTweetData(user);
            foreach (var item in tweets)
                model.Add(item);
            UserDialogs.Instance.HideLoading();
        }

        private async void onGetTweet(object sender, EventArgs e)
        {
            await BindTweets(txtTwitter.Text);
        }
    }
}
