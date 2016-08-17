using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    /// An page that allows user to write a review for a movie
    /// </summary>
    public sealed partial class WriteReviewPage : Page
    {
        private Review _review;

        private Author _author;

        public WriteReviewPage()
        {
            this.InitializeComponent();

        }

        /// <summary>
        /// When a review is submitted the values will be passed and stored
        /// A message diaglog will appear to indicate if it was successful or not
        /// It will then clear all the inputs and set the boxes to deault
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnSubmit(object sender, RoutedEventArgs e)
        {
            _author = new Author(_authorBlock);

            _review = new Review(_movieCombo.ToString(), _rateCombo.ToString(), _reviewBlock.ToString(), _author);

            DataStorage.SaveData(_review);

            var submit = new MessageDialog("Review has been submitted");
            await submit.ShowAsync();

            _movieCombo.SelectedIndex = 0;
            _rateCombo.SelectedIndex = 0;
            _reviewBlock.Text = "";


        }

        private void OnReturn(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }


    }
}