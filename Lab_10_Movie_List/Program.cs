using System;
using System.Collections;
using System.Collections.Generic;
namespace Lab_10_Movie_List
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Movie> movies = new List<Movie>
            {
            new Movie("Casablanca", "Drama"),
            new Movie("Citizen Kane", "Drama"),
            new Movie("Bambi", "Animated"),
            new Movie("Alien", "Sci-Fi"),
            new Movie("The Wizard of Oz", "Drama"),
            new Movie("Shawshank Redemption", "Drama"),
            new Movie("Beauty and the Beast", "Animated"),
            new Movie("Le Voyage dans la Lune", "Sci-Fi"),
            new Movie("Princess Bride", "Comedy"),
            new Movie("The VVitch", "Horror"),
             };
           
            Console.WriteLine("Find a category you like and see the list of movies in that category\n");

            bool continueLoop = true;
            while (continueLoop == true)
            {
                Movie.PrintCategoryList(movies);
                Movie.PrintMoviesByType(movies, InputIsInt(movies, GetUserInput("Pick a movie category: ")));

                continueLoop = YesOrNo("\nWould you like to pick another category ? (y/n) : ");
            }
        }

        public static int InputIsInt(List<Movie> movies, string pick)
        {
            try
            {
                int intPick = int.Parse(pick) - 1;
                string tryExceptionT = Movie.GetCategoryList(movies)[intPick];
                return intPick;
            }
            catch
            {
                Console.WriteLine("Invalid selection (catch)");
                return InputIsInt(movies, GetUserInput("Try again "));
            }
        }
        public static bool YesOrNo(string message)
        {
            string userContinue = "";
            while (userContinue != "y" && userContinue != "n")
            {
                Console.Write(message);
                userContinue = Console.ReadLine().ToLower();

                if (userContinue == "n")
                {
                    Console.WriteLine("Okay!!");
                    return false;
                }
            }
            Console.WriteLine();
            return true;
        }
        public static string GetUserInput(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return input;
        }
    }
}




/*store a LIST of 10 movies and displays them by CATEGORY
 * the user can enter animated, drama, horror, scifi
 * after the list is displayed ask Y/N to continue: N ends Y loops
 * Each Movie Should be represented by an object of type Movie
 * the Movie class must provide two private fields: title and category properties
 * the class should also provide a constructor that accepts a title and a category as paraemeter and uses the values passed into it to INITIALIZE it's fields
 * when the user enter a category the program should read through all of the movies in the LIST and display a line for any mobie whose category matches the category entered by the user
 * validate the input don't accept blanks for any of the questions
 * **standardize the category codes by displaying a menu of categories and having the user select the category by number reather than entering the name
 * display the moies for the selected category in alphabetical order
 * */
