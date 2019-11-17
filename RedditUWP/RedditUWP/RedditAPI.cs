using RedditSharp;
using RedditSharp.Things;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditUWP
{
    class RedditAPI
    {
        public static IEnumerable<Post> GetTop()
        {
            try
            {
                var reddit = new Reddit();
                var subreddit = reddit.FrontPage;

                IEnumerable<Post> topPosts = subreddit.GetTop(FromTime.All).Take(50);

                return topPosts;
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}
