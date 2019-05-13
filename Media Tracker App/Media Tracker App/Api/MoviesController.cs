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

        public List<Anime___Cartoons> GetMovies()
        {
            List<Anime___Cartoons> movies = null;
            
            movies = context.Anime___Cartoons.ToList();
          
            return movies;
        }
    }

}
