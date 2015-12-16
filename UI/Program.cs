using System;
using System.Collections.Generic;
using RepositorPatternDemo.Interfaces;
using RepositorPatternDemo.ViewModels;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fetching Data from different Data stores via Repository Pattern");

            FetchMovie("Azure");
            FetchMovie("AWS");
            FetchMovie("SQL");
            Console.ReadLine();
        }

        private static void FetchMovie(string repositoryType)
        {
            IMovieRepo movieRepo = RepositoryFactory.GetMovieRepo(repositoryType);

           IEnumerable<Movie> movies = movieRepo.GetMovies();

            foreach (var item in movies)
            {
                Console.WriteLine("Movie Name:- "+item.MovieName+
                    "Director Name:- "+item.DirectorName+
                    "Release Year:- "+item.ReleaseYear);  
            }
            Console.WriteLine("-------------------------------------------------------------------");
        }
    }
}
