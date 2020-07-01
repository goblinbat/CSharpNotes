using _07_RepositoryPattern_Repository;
using _08_StreamingContent_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Console.UI
{
    public class ProgramUI
    {
        private readonly StreamingRepository _streamingRepo = new StreamingRepository();

        public void Run()
        {
            SeedContentList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueRunning = true;
            while (continueRunning)
            {
                Console.Clear();
                Console.WriteLine(
                    "Enter the number of the option you'd like to select: \n" +     // hit enter in the quotes and it'll automatically close the quotes, add the +, and drop to a new line with ""
                    "1. Show all streming content \n" +
                    "2. Find streaming content by title \n" +
                    "3. Add new streaming content \n" +
                    "4. Remove streaming content \n" +
                    "5. Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":   // show all
                        ShowAllContent();
                        break;
                    case "2":   // find by title
                        FindByTitle();
                        break;
                    case "3":   // add new
                        CreateNewContent();
                        break;
                    case "4":   // remove
                        RemoveContent();
                        break;
                    case "5":   // exit
                        continueRunning = false;
                        break;
                    //default:    // invalid input
                    //    Console.WriteLine("Please enter a valid number between 1 and 5\n" +
                    //        "Press any key to continue");
                    //    Console.ReadKey();
                    //    break;
                }
            }
        }

        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent content = new StreamingContent();
            // title
            Console.WriteLine("Please enter the title of the content: ");
            content.Title = Console.ReadLine();
            // description
            Console.WriteLine("\nPlease enter the description: ");
            content.Description = Console.ReadLine();
            // maturity rating
            // this is one way to do this; we'll use another way for genre
            Console.WriteLine("\nSelect a maturity rating: \n" +
                "1. G \n" +
                "2. PG \n" +
                "3. PG 13 \n" +
                "4. R \n" +
                "5. NC 17 \n" +
                "6. TV MA");
            string matString = Console.ReadLine();
            switch (matString)
            {
                case "1":
                    content.MaturityRating = MaturityRating.G;
                    break;
                case "2":
                    content.MaturityRating = MaturityRating.PG;
                    break;
                case "3":
                    content.MaturityRating = MaturityRating.PG_13;
                    break;
                case "4":
                    content.MaturityRating = MaturityRating.R;
                    break;
                case "5":
                    content.MaturityRating = MaturityRating.NC_17;
                    break;
                case "6":
                    content.MaturityRating = MaturityRating.TV_MA;
                    break;
            }
            // star rating
            Console.WriteLine("\nPlease enter the star rating (1-5): ");
            content.StarRating = int.Parse(Console.ReadLine());
            // genre
            Console.WriteLine("\nSelect a Genre:\n" +   // need to be in the same order as the enum
                "1. Horror \n" +
                "2. Science Fiction\n" +
                "3. Drama \n" +
                "4. Action \n" +
                "5. Comedy \n" +
                "6. Anime \n" +
                "7. Documentary \n" +
                "8. Romance \n" +
                "9. Thriller \n" +
                "10. Mystery");
            string genreInput = Console.ReadLine();
            int genreID = int.Parse(genreInput);
            content.TypeOfGenre = (GenreType)genreID;   // casting
            // now add it to the repository
            _streamingRepo.AddContentToDirectory(content);
        }

        private void ShowAllContent()
        {
            Console.Clear();
            List<StreamingContent> listOfContent = _streamingRepo.GetContents();
            foreach (StreamingContent contentVariable in listOfContent)
            {
                DisplayContent(contentVariable);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private void DisplayContent(StreamingContent content)
        {
            Console.WriteLine($"{content.Title}: {content.Description}\n" +
                    $"{content.StarRating} stars, rated {content.MaturityRating}, genre: {content.TypeOfGenre}\n" +
                    $"Family friendly: {content.IsFamilyFriendly}\n" +
                    $"_______________________________________\n");
        }

        private void FindByTitle()
        {
            Console.Clear();
            Console.WriteLine("Enter the title you're searching for: ");
            string searchTitle = Console.ReadLine();
            StreamingContent foundTitle = _streamingRepo.GetByTitle(searchTitle);
            if(foundTitle != null)
            {
                DisplayContent(foundTitle);
            }
            else
            {
                Console.WriteLine("No results found");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private void RemoveContent()
        {
            Console.WriteLine("Which item would you like to remove? ");
            List<StreamingContent> contentList = _streamingRepo.GetContents();
            int count = 0;
            foreach(StreamingContent content in contentList)
            {
                count++;
                Console.WriteLine($"{count}. {content.Title}");
            }
            int targetContentId = int.Parse(Console.ReadLine());
            int targetIndex = targetContentId - 1;  // to offset count++
            if(targetIndex >= 0 && targetIndex < contentList.Count)
            {
                StreamingContent desiredContent = contentList[targetIndex];
                if (_streamingRepo.DeleteContent(desiredContent))
                {
                    Console.WriteLine($"Deleted {desiredContent.Title}");
                }
                else
                {
                    Console.WriteLine($"an error occurred and {desiredContent.Title} was not removed");
                }
            }
            else
            {
                Console.WriteLine("No content has that ID");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private void SeedContentList()
        {
            StreamingContent movieOne = new StreamingContent("2020", "oh no", MaturityRating.PG_13, 1, GenreType.Horror);
            StreamingContent movieTwo = new StreamingContent("Macy's lemonade stand", "Macy starts a lemonade stand for all her friends", MaturityRating.R, 3, GenreType.Thriller);
            StreamingContent movieThree = new StreamingContent("Mothman", "All about the mothman", MaturityRating.NC_17, 4, GenreType.Documentary);
            StreamingContent movieFour = new StreamingContent("Jasper", "Jasper and their friends go on adventures around their small town", MaturityRating.PG, 3, GenreType.Comedy);

            _streamingRepo.AddContentToDirectory(movieOne);
            _streamingRepo.AddContentToDirectory(movieTwo);
            _streamingRepo.AddContentToDirectory(movieThree);
            _streamingRepo.AddContentToDirectory(movieFour);
        }
    }
}
