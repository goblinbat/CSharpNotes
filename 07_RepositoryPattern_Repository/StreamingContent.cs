using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public enum GenreType
    {
        Horror = 1,      // =1 makes this index 1 instead of 0
        SciFi,
        Drama,
        Action,
        Comedy,
        Anime,
        Documentary,
        Romance,
        Thriller,
        Mystery
    }

    public enum MaturityRating { G, PG, PG_13, R, NC_17, TV_MA }
    public class StreamingContent
    {
        public string Title { get; set; }       // type "prop" and double tab to quickly add a property
        public string Description { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public int StarRating { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                switch (MaturityRating) 
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.PG_13:
                        return true;
                    case MaturityRating.R:
                    case MaturityRating.NC_17:
                    case MaturityRating.TV_MA:
                    default:
                        return false;
                }

                /// Another Option:
                /*if((int)MaturityRating > 2)
                {
                    return false;
                }
                else
                {
                    return true;
                }*/
            }
        }
        public GenreType TypeOfGenre { get; set; }

        public StreamingContent() { }       // ctor + double tab will quickly build an empty constructor
        public StreamingContent(string title, string description, MaturityRating maturityRating, int starRating, GenreType genre)
        {
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            TypeOfGenre = genre;
        }
    }
}
