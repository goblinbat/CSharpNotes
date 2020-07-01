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
                        break;
                    case "3":   // add new
                        CreateNewContent();
                        break;
                    case "4":   // remove
                        break;
                    case "5":   // exit
                        continueRunning = false;
                        break;
                    default:    // invalid input
                        Console.WriteLine("Please enter a valid number between 1 and 5\n" +
                            "Press any key to continue");
                        Console.ReadKey();
                        break;
                }
            }
            Console.WriteLine("Have a nice day!");
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
                Console.WriteLine($"{contentVariable.Title}: {contentVariable.Description}\n" +
                    $"{contentVariable.StarRating} stars, rated {contentVariable.MaturityRating}, genre: {contentVariable.TypeOfGenre}\n\n");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }


    }
}
