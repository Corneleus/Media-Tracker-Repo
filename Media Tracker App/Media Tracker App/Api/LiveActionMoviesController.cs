using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Media_Tracker_App.Models;

namespace Media_Tracker_App.Api
{
    public class LiveActionMoviesController : ApiController
    {//path is /api/liveactionmovies/getmovies
        DBEntities _ctx = null; 

        public LiveActionMoviesController()
        {
            _ctx = new DBEntities();
        }
        public List<Live_Action_Movies> GetMovies()
        {
            List<Live_Action_Movies> movies = null;
            try
            {
                movies = _ctx.Live_Action_Movies.ToList();
            }
            catch
            {
                movies = null;
            }
            return movies;
        }
    }
}
