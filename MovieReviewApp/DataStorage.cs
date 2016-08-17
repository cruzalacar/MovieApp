using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReviewApp
{
    public static class DataStorage
    {

        /// <summary>
        /// This method is tasked to run on start up, where it will access a text file and search for reviews for a selected movie title.
        /// Once it locates a section with the intended movie title, it will create review objects and add them to a list of movie reviews.
        /// The new list will be returned to the caller of the method
        /// </summary>
        /// <param name="targetMovieTitle">This parameter will be used in a json query to locate all reviews with the passed movie title</param>
        /// <returns>Returns a movie review list containing all the reviews for the specified movie</returns>
        public static void LoadData(string targetMovieTitle)
        {

        }

        /// <summary>
        /// This method will take review objects passed from WriteReviewPage. 
        /// It will add the object to the review list and writes the data to a file
        /// </summary>
        /// <param name="CurrentReviewList">Takes a Review list as a parameter to add to a json file</param>
        public static void SaveData(Review CurrentReview)
        {

        }

        /// <summary>
        /// This will scan a json file and return a review object containing the same movie title
        /// </summary>
        /// <param name="targetMovieTitle">This parameter will be used in a json query to locate all reviews with the passed movie title</param>
        public static void RetriveData(string targetMovieTitle)
        {

        }
    }
}
