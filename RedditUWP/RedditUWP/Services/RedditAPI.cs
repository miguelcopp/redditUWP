using RedditSharp;
using RedditSharp.Things;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RedditUWP
{
    class RedditAPI
    {
        // Get the top 50 of the Reddit entries by all the time.
        public static IEnumerable<Post> GetTop()
        {
            try
            {
                var reddit = new Reddit();
                var subreddit = reddit.FrontPage;

                IEnumerable<Post> topPosts = subreddit.GetTop(FromTime.All).Take(50);

                return topPosts;
            }
            catch(Exception e)
            {
                Console.Write("Error: " + e);
                return null;
            }
        }
    }
}
