using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace MovieReviewApp
{
    public class Author
    {
        /// <summary>
        /// name of author
        /// </summary>
        private TextBox _name;

        /// <summary>
        /// constructor for author conatins name
        /// </summary>
        /// <param name="name"></param>
        public Author(TextBox name)
        {
            _name = name;
        }

        public TextBox Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
