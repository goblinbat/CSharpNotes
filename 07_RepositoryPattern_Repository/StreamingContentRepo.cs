using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
   
    public class StreamingContentRepo       // make sure to add public access modifier!!
    {
        // normally a repository interacts with a database; we don't have one so we're just using a list
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>(); // protected means that we can't reassign it later; it always will point to the same spot on the heap. readonly means we can't access it from outside this file (unless it's via a method imported /from/ this file)

        // Crud: Create
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        // cRud: Read
        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }

        public StreamingContent GetByTitle(string title)
        {
            foreach (StreamingContent item in _contentDirectory)
            {
                if (item.Title.ToLower() == title.ToLower())
                {
                    return item;
                }
            }
            return null;    // return null is not best practice but it works and we're not doing a lot of exception handling or anything rn
        }

        public List<StreamingContent> GetByFamilyFriendly(bool familyFriendly)
        {
            List<StreamingContent> friendlies = new List<StreamingContent>();
            foreach (StreamingContent item in _contentDirectory)
            {
                if (item.IsFamilyFriendly == familyFriendly)
                {
                    friendlies.Add(item);
                }
            }
            return friendlies;
        }

        // crUd: Update
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetByTitle(originalTitle);
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;  // yes, it will reevaluate IsFamilyFriendly (or, rather, IsFamilyFriendly is evaluated every time it's called upon)
                oldContent.StarRating = newContent.StarRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;
                return true;
            }
            else
            {
                return false;
            }
        }

        // cruD: Destroy or Delete
        public bool DeleteContent(StreamingContent content)
        {
            bool deleteResult = _contentDirectory.Remove(content);
            return deleteResult;

        }
    }
}
