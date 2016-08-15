using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace MovieReviewApp
{
    class CreateReview
    {
        private ComboBoxItem _title;
        private ComboBoxItem _star;
        private string _review;

        public CreateReview(ComboBoxItem title, ComboBoxItem star, string review)
        {
            _title = title;
            _star = star;
            _review = review;
        }


    }
}
