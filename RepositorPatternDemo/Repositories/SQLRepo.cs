using System.Collections.Generic;
using RepositorPatternDemo.Interfaces;
using RepositorPatternDemo.ViewModels;

namespace RepositorPatternDemo.Repositories
{
   public class SQLRepo : IMovieRepo
    {
        public IEnumerable<Movie> GetMovies()
        {
            //Returning Dummy data just for demo, underline implementation doesn't matter in this case.
            //For building End To End project using design patterns,
            //Refer my book http://ow.ly/Jh4bI

            return new List<Movie>
           {
               new Movie
               {
                   DirectorName = "Gareth Edwards",
                   MovieName = "Godzilla",
                   ReleaseYear = "2014"
               },
               new Movie
               {
                   DirectorName = "James Cameron",
                   MovieName = "Avatar",
                   ReleaseYear = "2009"
               },
               new Movie
               {
                   DirectorName = "James Cameron",
                   MovieName = "Titanic",
                   ReleaseYear = "1997"
               },
               new Movie
               {
                   DirectorName = "Lee Tamahori",
                   MovieName = "Die Another Day",
                   ReleaseYear = "2002"
               },
                new Movie
               {
                   DirectorName = "Colin Trevorrow",
                   MovieName = "Jurassic World",
                   ReleaseYear = "2015"
               }
           };
        }

        public Movie GetMovie(string movieName)
        {
            throw new System.NotImplementedException();
        }

        public void AddMovie(Movie newmovie)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateMovie(string movieName)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteMovie(string movieName)
        {
            throw new System.NotImplementedException();
        }
    }
}
