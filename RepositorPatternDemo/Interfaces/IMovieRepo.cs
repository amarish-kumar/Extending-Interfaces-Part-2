using System.Collections.Generic;
using RepositorPatternDemo.ViewModels;

namespace RepositorPatternDemo.Interfaces
{
  public interface IMovieRepo
  {
      //Basic CRUD opeartions. You can add many more operations here
      IEnumerable<Movie> GetMovies();
      Movie GetMovie(string movieName);
      void AddMovie(Movie newmovie);
      void UpdateMovie(string movieName);
      void DeleteMovie(string movieName);
      
  }
}
