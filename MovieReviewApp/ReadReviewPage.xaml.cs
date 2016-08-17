using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MovieReviewApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ReadReviewPage : Page
    {
        public ReadReviewPage()
        {
            this.InitializeComponent();
        }

        private void OnReturn(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void OnTarzanSelect(object sender, RoutedEventArgs e)
        {
            movieTitle.Content = "Tarzan";

            _reviewBlock.Items.Clear();

            _reviewBlock.Items.Add("-------------------\nRating: 3/5" + "\nReview: Good for it's time. Nostalgic." + "\nReviewer: John Smith\n-------------------");
            _reviewBlock.Items.Add("-------------------\nRating: 4/5" + "\nReview: Pretty old, but pretty good." + "\nReviewer: Joe Balkans\n-------------------");
        }

        private void OnMadMaxSelect(object sender, RoutedEventArgs e)
        {
            movieTitle.Content = "Mad Max: Fury Road";

            _reviewBlock.Items.Clear();

            _reviewBlock.Items.Add("-------------------\nRating: 4/5" + "\nReview: Doesn't compare to the originals." + "\nReviewer: John Smith\n-------------------");
            _reviewBlock.Items.Add("-------------------\nRating: 5/5" + "\nReview: Best directed movie of 2015." + "\nReviewer: Joe Balkans\n-------------------");
            _reviewBlock.Items.Add("-------------------\nRating: 100000/5" + "\nReview: *Music plays*" + "\nReviewer: JOHN CENA\n-------------------");
        }

        private void OnNatureCallsSelect(object sender, RoutedEventArgs e)
        {
            movieTitle.Content = "Ace Ventura: When Nature Calls";

            _reviewBlock.Items.Clear();

            _reviewBlock.Items.Add("-------------------\nRating: 5/5" + "\nReview: One of the best Ace Ventura movies to date!" + "\nReviewer: John Smith\n-------------------");
            _reviewBlock.Items.Add("-------------------\nRating: 5/5" + "\nReview: Can't get better than Jim Carrey. He's my favorite!" + "\nReviewer: Joe Balkans\n-------------------");
        }

        private void OnHolyGrailSelect(object sender, RoutedEventArgs e)
        {
            movieTitle.Content = "Monty Python And The Holy Grail";

            _reviewBlock.Items.Clear();

            _reviewBlock.Items.Add("-------------------\nRating: 5/5" + "\nReview: Pretty good for it's time." + "\nReviewer: John Smith\n-------------------");
            _reviewBlock.Items.Add("-------------------\nRating: 5/5" + "\nReview: Was it an African Swallow?" + "\nReviewer: Joe Balkans\n-------------------");
            _reviewBlock.Items.Add("-------------------\nRating: 0/5" + "\nReview: It was just a flesh wound." + "\nReviewer: The Black Knight\n-------------------");
        }
    }
}