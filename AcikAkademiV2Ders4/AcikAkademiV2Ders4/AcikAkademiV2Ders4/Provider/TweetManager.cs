using LinqToTwitter;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace AcikAkademiV2Ders4.Provider
{
    public class Tweets
    {
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public string Tweet { get; set; }
        public string ProfilePicture { get; set; }
    }

    public class TweetManager
    {
        const string accessToken = "1623197311-flc1WqXRYh45Saq0FclM3kjvRCVAQqHJrRWJn8U";
        const string accessTokenSecret = "smIpqIpNkNC3gTn2i21nJxCmHZzUcVXWKNFe9wZeBu9cv";
        const string consumerKey = "ZkWy4uOKXInR5cKMHKmJDIJf3";
        const string consumerSecretKey = "0GbZTHONrLI6fzpau12YSrBC3wU4rhsuufYbBVh50ipwJbvYLc";

        private static SingleUserAuthorizer GetTwitterAuth()
        {
            return new SingleUserAuthorizer
            {
                CredentialStore = new InMemoryCredentialStore
                {
                    ConsumerKey = consumerKey,
                    ConsumerSecret = consumerSecretKey,
                    OAuthToken = accessToken,
                    OAuthTokenSecret = accessTokenSecret
                }
            };
        }

        public async Task<List<Tweets>> GetHashTagData(string hashtag)
        {
            var list = new List<Tweets>();
            var twitterContext = new TwitterContext(GetTwitterAuth());

            var hashtags = await (from search in twitterContext.Search
                            where search.Type == SearchType.Search &&
                            search.Query == "#" + hashtag
                            select search).ToListAsync();

            foreach (var item in hashtags)
            {
                foreach (var tweet in item.Statuses)
                {
                    list.Add(new Tweets
                    {
                        Name = tweet.User.Name,
                        Tweet = tweet.Text,
                        Time = tweet.CreatedAt,
                        ProfilePicture = tweet.User.ProfileImageUrl
                    });
                }
            }

            return list;
        }

        public async Task<List<Tweets>> GetTweetData(string twitterAccount)
        {
            var list = new List<Tweets>();
            var twitterContext = new TwitterContext(GetTwitterAuth());

            var statusTweets = await (from tweet in twitterContext.Status
                                where tweet.Type == StatusType.User &&
                                tweet.ScreenName == twitterAccount &&
                                tweet.IncludeContributorDetails == true &&
                                tweet.Count == 10 &&
                                tweet.IncludeEntities == true
                                select tweet).ToListAsync();

            foreach (var item in statusTweets)
            {
                list.Add(new Tweets
                {
                    Name = item.User.Name,
                    Tweet = item.Text,
                    Time = item.CreatedAt,
                    ProfilePicture = item.User.ProfileImageUrl
                });
            }

            return list;
        }
    }
}