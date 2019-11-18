using System;
using Windows.UI.Xaml.Data;

namespace RedditUWP
{
    // Returns the date formated in the format "x months ago"
    public class StringFormatConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            try
            {
                DateTime postDate = DateTime.Parse(value.ToString());

                var diffDates = ((DateTime.Now.Year - postDate.Year) * 12) + DateTime.Now.Month - postDate.Month;

                return diffDates;
            }
            catch(Exception e)
            {
                Console.Write("Error: " + e);
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
