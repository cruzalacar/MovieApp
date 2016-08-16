﻿using System;
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

        /// <summary>
        /// Constructor requires title, rate, description and author
        /// </summary>
        /// <param name="title"> The movie title</param>
        /// <param name="rate"> The rating of the movie </param>
        /// <param name="descript"> short review on the movie </param>
        /// <param name="author"> author of review</param>
        public Review(string title, int rate, string descript, Author author)
        {
            _title = title;
            _rate = rate;
            _descript = descript;
            _author = author;
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }

        public string Descript
        {
            get { return _descript; }
            set { _descript = value; }
        }

        public Author Author
        {
            get { return _author; }
            set { _author = value; }
        }

    }
}
