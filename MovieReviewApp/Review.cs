using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReviewApp
{
    class Review
    {
        /// <summary>
        /// movie title has-a relationship with movie
        /// </summary>
        private string _title;

        /// <summary>
        /// rating author gives to movie
        /// </summary>
        private int _rate;

        /// <summary>
        /// a short discription of author's thoughts on the movie
        /// </summary>
        private string _descript;

        /// <summary>
        /// author of the review has-a relationship with Author class
        /// </summary>
        private Author _author;

        public Review(string title, int rate, string descript, Author author)
        {
            _title = title;
            _rate = rate;
            _descript = descript;
            _author = author;
        }
    }
}
