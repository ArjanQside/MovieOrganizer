using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Search;

namespace Movie_Organizer
{
    class Api
    {
        //Make a connection with api using a client
        public TMDbClient client = new TMDbClient("3f56e74337f276b7d6620dd475045995");
        //search movie
        public SearchContainer<SearchMovie> searchMovie(string name)
        {
            SearchContainer<SearchMovie> results = client.SearchMovie(name);
            return results;
        }
        //get movie data by id
        public TMDbLib.Objects.Movies.Movie GetMovie(int id)
        {
            TMDbLib.Objects.Movies.Movie m = client.GetMovie(id);
            return m;
        }
        //search tvshow
        public SearchContainer<SearchTv> searchTv(string name)
        {
            SearchContainer<SearchTv> results = client.SearchTvShow(name);
            return results;
        }
        //get tvshow data by id
        public TMDbLib.Objects.TvShows.TvShow GetTvShow(int id)
        {
            TMDbLib.Objects.TvShows.TvShow tv = client.GetTvShow(id);
            return tv;
        }
    }
}
