using _07_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Inheritance
{
    public class StreamingRepository : StreamingContentRepo
    {
        public Show GetShowByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show))
                {
                    return (Show)content;
                }
            }
            return null;
        }

        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content is Movie)
                {
                    return (Movie)content;
                }
            }
            return null;
        }

        public List<Show> GetAllShows()
        {
            List<Show> allShows = new List<Show>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Show)
                {
                    allShows.Add((Show)content);
                }
            }
            return allShows;
        }

        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie movie)
                {
                    allMovies.Add(movie);
                }
            }
            return allMovies;
        }

        // Challenge: Get by runtime/average runtime
        public List<Show> GetShowsByRuntime(double runtime)
        {
            List<Show> shows = new List<Show>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Show show && show.AverageRunTime == runtime)
                {
                    shows.Add(show);
                }
            }
            return shows;
        }

        public List<Movie> GetMoviesByRuntime(double runtime)
        {
            List<Movie> movies = new List<Movie>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie movie && movie.RunTime == runtime)
                {
                    movies.Add(movie);
                }
            }
            return movies;
        }

        // Challenge: get shows w/ > x episodes
        public List<Show> GetShowsWithMinEpisodes(int minEpisodeNumber)
        {
            List<Show> shows = new List<Show>();
                foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Show show && show.EpisodeCount >= minEpisodeNumber)
                {
                    shows.Add(show);
                }
            }
            return shows;
        }

        // Challenge: get shows/movies by rating
        public List<Show> GetShowsByMaturityRating(MaturityRating maturityRating)
        {
            List<Show> shows = new List<Show>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Show show && show.MaturityRating == maturityRating)
                {
                    shows.Add(show);
                }
            }
            return shows;
        }

        public List<Movie> GetMoviesByMaturityRating(MaturityRating maturityRating)
        {
            List<Movie> movies = new List<Movie>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie movie && movie.MaturityRating == maturityRating)
                {
                    movies.Add(movie);
                }
            }
            return movies;
        }
    }
}
