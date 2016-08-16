using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace MovieReviewApp
{
    class ReviewProgram
    {
        private Review _review;

        public void LoadReview()
        {

        }

        public void SaveReview(Review review)
        {
            


        }

        public string RetriveReview(ComboBoxItem title)
        {
            return title.ToString();
        }
    }
}
