using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4._2Movies
{
    class Movie
    {
        private string title;
        private string category;

        public String Title 
        {
            get 
            {
                return title;
            }
            set 
            {
                title = value;
            }
        }

        public string Category 
        {
            get 
            {
                return category;
            }
            set 
            {
                category = value;
            }
        }

        public Movie(string aTitle, string aCategory) 
        {
            Title = aTitle;
            Category = aCategory;
        }
    }
}
