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
        private bool _status = true; 

        public ReadReviewPage()
        {
            this.InitializeComponent();
        }

        private void OnReturn(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void OnSelected(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            _status = !cmb.IsDropDownOpen;

            DataStorage.RetrieveData(_movieCombo.ToString());
        }


    }
}