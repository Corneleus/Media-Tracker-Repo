using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Media_Tracker_App.Models;

namespace Media_Tracker_App.Api
{
    public class MoviesController : ApiController
    {//path is /api/movies/getmovies
        Media_ListsEntities _ctx = null;

        public MoviesController() => _ctx = new Media_ListsEntities();
        public List<Movies> GetMovies()
        {
            List<Movies> movies = null;
            try
            {
                movies = _ctx.Movies.ToList();
            }
            catch
            {
                movies = null;
            }
            return movies;
        }
    }

}
