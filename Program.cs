using System;
using System.Collections.Generic;

namespace Lab4._2Movies
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 10 movies in this list!");
            List <Movie> movieList = new List<Movie>();
            
            movieList.Add(new Movie("Finding Nemo", "Animated"));
            movieList.Add(new Movie("Lion King", "Animated"));
            movieList.Add(new Movie("Toy Story", "Animated"));
            movieList.Add(new Movie("Gone with the Wind", "Drama"));
            movieList.Add(new Movie("Dances with Wolves", "Drama"));
            movieList.Add(new Movie("The Hills have Eyes", "Horror"));
            movieList.Add(new Movie("House of 1000 Corpses", "Horror"));
            movieList.Add(new Movie("Star Wars", "Sci-fi"));
            movieList.Add(new Movie("Aliens", "Sci-Fi"));
            movieList.Add(new Movie("Cowboys and Aliens", "Scifi"));

            string proceed = "y";

            while (proceed == "y")

            {

                Console.Write("What category are you interested in?: ");
                string userCategorySelected = Console.ReadLine();


                List<Movie> userFilteredList = new List<Movie>();

                foreach (Movie film in movieList)
                {

                    if (userCategorySelected == film.Category)
                    {
                        userFilteredList.Add(film);
                        Console.WriteLine(film.Title);
                    }
                }

                Console.Write("Continue? (y/n): ");
                proceed = Console.ReadLine();

                if (proceed == "n") 
                {
                    Console.WriteLine("Goodbye!");
                }

                //foreach (Movie film in movieList)
                //{
                //    if(userCategorySelected == film.Category)
                //    Console.WriteLine(film.Title);
                //}


                //movieList.Add("Finding Nemo");
                //movieList.Add("Toy Stry")

                //movieList.Add(new Movie { PartName = "crank arm", PartId = 1234 });
            }
        }
    }
}
