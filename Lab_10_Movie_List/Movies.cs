﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10_Movie_List
{
    class Movie
    {
        #region Fields
        private string title;
        private string category;
        #endregion

        #region Properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        #endregion

        #region Constructors
        public Movie(string _title, string _category)
        {
            title = _title;
            category = _category;
        }
        #endregion

        #region Methods
        public static void PrintCategoryList(List<Movie> movies)
        {
            List<string> categoryList = GetCategoryList(movies);
            for (int i = 0; i < categoryList.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {categoryList[i]}");
            }
            Console.WriteLine();
        }
        public static List<string> GetCategoryList(List<Movie> movieList)
        {
            List<string> categoryList = new List<string>();
            foreach (Movie movie in movieList)
            {
                if (!categoryList.Contains(movie.category))
                {
                    categoryList.Add(movie.category);
                }
            }
            categoryList.Sort();
            return categoryList;
        }
        public static void PrintMoviesByType(List<Movie> movieList, int typeSelected)
        {
            List<string> listOfCategories = new List<string>();
            int num = 0;
            for (int i = 0; i < movieList.Count; i++)
            {
                if (typeSelected == GetCategoryList(movieList).IndexOf(movieList[i].category))
                {
                    listOfCategories.Add(movieList[i].title);
                }
            }
            listOfCategories.Sort();
            foreach (string movie in listOfCategories)
            {
                num++;
                Console.WriteLine($"{num}: {movie}");
            }
        }
        public static void PrintMoviesByType(List<Movie> movieList, string typeSelected)
        {
            List<string> listOfCategories = new List<string>();
            int num = 0;
            for (int i = 0; i < movieList.Count; i++)
            {
                if (typeSelected == movieList[i].category)
                {
                    listOfCategories.Add(movieList[i].title);
                }
            }
            listOfCategories.Sort();
            foreach (string movie in listOfCategories)
            {
                num++;
                Console.WriteLine($"{num}: {movie}");
            }
        }
        #endregion
    }
}