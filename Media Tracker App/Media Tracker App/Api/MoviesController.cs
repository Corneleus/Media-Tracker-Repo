using Media_Tracker_App.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;



namespace Media_Tracker_App.Api
{
    public class MoviesController : ApiController
    {
        //path is /api/movies/getmovies
        
        Media_ListsEntities context = null;

        public MoviesController() => context = new Media_ListsEntities();

        public List<Movies> GetMovies()
        {
            List<Movies> movies = null;
            
            movies = context.Movies.ToList();
          
            return movies;
        }
    }

}
