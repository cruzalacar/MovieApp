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
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WriteReviewPage : Page
    {
        public WriteReviewPage()
        {
            this.InitializeComponent();
        }

        private async void OnSubmit(object sender, RoutedEventArgs e)
        {

            var submit = new MessageDialog("Review has been submitted");
            await submit.ShowAsync();

            _movieCombo.SelectedIndex = 0;
            _starCombo.SelectedIndex = 0;
            _reviewBlock.Text = "";


        }

        private void OnReturn(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void FillMovieCombo(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    string text = File.ReadAllText("C:/Users/Owner/Documents/Mobile Computing/SEMESTER TWO/PROG10065 - Interative Development/TermProjectMovie");

                    while (text != null)
                    {
                        _movieCombo.Items.Add(text);
                    }
                }
                catch (Exception ex)
                {
                    var exce = new MessageDialog("Review has been submitted");
                }
            }
        }
    }
}