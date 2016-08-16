using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReviewApp
{
    class Author
    {
        /// <summary>
        /// name of author
        /// </summary>
        private string _name;

        /// <summary>
        /// constructor for author conatins name
        /// </summary>
        /// <param name="name"></param>
        public Author(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
