using RedditSharp.Things;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace RedditUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnGetTop_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Post> topList = RedditAPI.GetTop();
            postsList.ItemsSource = topList;
        }
    }
}
