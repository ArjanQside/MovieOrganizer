using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Search;

namespace Movie_Organizer
{
    public partial class SearchForm : Form
    {
        IDictionary<string, int> SearchMovies = new Dictionary<string, int>();
        IDictionary<string, int> SearchTvShows= new Dictionary<string, int>();
        KeyValuePair<string, string> NameAndFolder;
        Api api = new Api();

        public SearchForm(KeyValuePair<string, string>nameandfolder)
        {
            InitializeComponent();
            NameAndFolder = nameandfolder;
        }
        private void SearchForm_Load(object sender, EventArgs e)
        {
            //search movies
            foreach (SearchMovie result in api.searchMovie(NameAndFolder.Key).Results)
                SearchMovies[result.Title] = result.Id;
            foreach (var item in SearchMovies)
                MovieResultBox.Items.Add(item.Key);
            //search tvshows
            foreach (SearchTv result in api.searchTv(NameAndFolder.Key).Results)
                SearchTvShows[result.Name] = result.Id;
            foreach (var item in SearchTvShows)
                TVShowResultBox.Items.Add(item.Key);
        }

        //Cancel button handler
        private void SearchCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //Ok burron handler
        private void SearchOkButton_Click(object sender, EventArgs e)
        {
           if(SearchTab.SelectedTab.Name == tabPage1.Name)
           {
                int MovieID = SearchMovies[MovieResultBox.GetItemText(MovieResultBox.SelectedItem)];
                TMDbLib.Objects.Movies.Movie movieData = api.GetMovie(MovieID);
                Movie movie = new Movie();
                movie.id = movieData.Id;
                movie.filePath = NameAndFolder.Value;
                movie.genre = new List<string>();
                foreach(Genre genre in movieData.Genres)
                    movie.genre.Add(genre.Name);
                movie.summary = movieData.Overview;
                movie.title = movieData.Title;
                DateTime s = Convert.ToDateTime(movieData.ReleaseDate);
                movie.year = s.Year.ToString();
                WebClient wc = new WebClient();
                wc.DownloadFile("https://image.tmdb.org/t/p/w185" + movieData.PosterPath, NameAndFolder.Value + "\\movie.jpg"); 
                NFO.WriteMovieNFO(movie);
           }
           else if(SearchTab.SelectedTab.Name == tabPage2.Name)
           {
                int TvShowID = SearchTvShows[TVShowResultBox.GetItemText(TVShowResultBox.SelectedItem)];
           }
        }
    }
}
