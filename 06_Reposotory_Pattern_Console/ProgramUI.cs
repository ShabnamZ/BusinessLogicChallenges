using _06_Reposotory_Pattern;
using System;
using System.Collections.Generic;

namespace _06_Reposotory_Pattern_Console
{
    public class ProgramUI //make sure the class is public
    {
        private StreamingContentRepository _streamingRepo = new StreamingContentRepository(); 
        public void Run()
        {
            SeedContentList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRunMenu = true;

            while (continueToRunMenu)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?\n" +
                                "1.Show all streaming content\n" +
                                "2.Find streaming content by title\n" +
                                "3.Add new streaming content\n" +
                                "4.Remove streaming content\n" +
                                "5.Exit");

                string userInput = Console.ReadLine();
                switch(userInput)
                {
                    case "1":
                        //Show all content
                        ShowAllContent();
                        break;

                    case "2":
                        //Find streaming content
                        ShowContentByTitle();
                        break;

                       case "3":
                        //Add new streaming content
                        CreateAndAddContentToLIst();
                        break;

                    case "4":
                        //Remove streaming content
                        
                        break;

                    case "5":
                        //Exit
                        continueToRunMenu = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 and 5.\n" +
                            "Press any key to continue..");
                        Console.ReadKey();
                        break;

                }
                
            }
 
        }

        private void CreateAndAddContentToLIst()
        {
            // Initialize a new streaming content object
            StreamingContent content = new StreamingContent();

            // Get Title
            Console.Write("Please enter a title: "); //takes you to the next line
            content.Title = Console.ReadLine();

            // Get Description
            Console.Write("Please enter a description: ");
            content.Description = Console.ReadLine();

            // Get RunTime in minutes
            Console.Write("Please enter a run time in minutes: ");
            string runTime = Console.ReadLine();
            content.RunTimeInMinutes = double.Parse(runTime);// changing string to double

            // Get Star Rating
            Console.Write("Please enter the star rating (1-5): ");
            content.StarRating = double.Parse(Console.ReadLine());

            // Get Maturity Rating
            Console.Write("Please enter the maturity rating (G, PG, etc.): ");
            content.MaturityRating = Console.ReadLine();

            // Get IsFamilyFriendly
            Console.Write("This  is family friendly (true/false):");
            content.IsFamilyFriendly = bool.Parse(Console.ReadLine());

            // Get GenreType
            Console.WriteLine("What is the genre?\n" +
                "1. Noir\n" +
                "2. Horror\n" +
                "3. RomCom\n " +
                "4. SciFi\n" +
                "5. WildWest\n" +
                "6. Documentary\n" +
                "7. Bromance\n" +
                "8. Drama\n" +
                "9. Action");
            int genreNumber = int.Parse(Console.ReadLine());
            content.TypeOfGenre = (GenreType)genreNumber; //casting - take a value and 


            // Add streaming content to repository list
            _streamingRepo.AddContentToList(content); // field that contain an object,it will persists
        }
        private void ShowAllContent()
        {
            List<StreamingContent> listOfContent = _streamingRepo.GetStreamingContentList();
            foreach(StreamingContent content in listOfContent)
            {
                Console.WriteLine($"{content.Title} { content.Description}");

            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void ShowContentByTitle()
        {
            //Prompt user to enter title

            Console.WriteLine("Enter a title:");

            // Get  and store user input

            string title = Console.ReadLine();

            // Find the matching content

           StreamingContent content = _streamingRepo.GetContentByTitle(title);

          // If there is no matching content say so
          if (content == null)
            {
                Console.WriteLine("Invalid title. Could not find any results.");
            }
            //Display the content to the console
            else
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                      $" Description: {content.Description}\n" +
                      $"Rating:{content.MaturityRating}\n" +
                      $"Lenght:{content.RunTimeInMinutes}\n" +
                      $"Stars: {content.StarRating}\n" +
                      $"Family Friendly:{content.IsFamilyFriendly}\n" +
                      $"Genre: {content.TypeOfGenre}");
                    

            }

            //Pause the program until they press a key
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }



       /* private void RemoveContent()
        {
            Console.WriteLine("Which item would you like to remove?");
            int count = 0;
            List<StreamingContent> contentList = _streamingRepo.GetStreamingContentList();
            foreach (StreamingContent content in contentList)
            {
                count++;
                Console.WriteLine($"{count}. {content.Title}");
            }

            int contentNumber = int.Parse(Console.ReadLine());
            int contentIndexNumber = contentNumber - 1;
            if (contentIndexNumber >= 0 && contentIndexNumber < contentList.Count)
            {
                StreamingContent desiredContent = contentList[contentIndexNumber];
                if (_streamingRepo.RemoveContentFromList(desiredContent))
                {
                    Console.WriteLine($"{desiredContent.Title} successfully removed");
                }
                else
                {
                    Console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that.");
                }
            }
            else
            {
                Console.WriteLine("No content has that ID.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }*/

        private void SeedContentList ()// it filles the content
        {
            StreamingContent rubber = new StreamingContent("Rubber", GenreType.Horror, " Tyre comes to life and kills people.", 120d, 5.8d, "R", false);
            StreamingContent toyStory = new StreamingContent("Toy Story", GenreType.Bromance, "Best childhood movie", 90d, 10.0d, "G", true);
            StreamingContent starWars = new StreamingContent("Star Wars", GenreType.SciFi, "Jar Jar saves the world", 1338, 10.0, "PG-13",true);

            _streamingRepo.AddContentToList(rubber);
            _streamingRepo.AddContentToList(toyStory);
            _streamingRepo.AddContentToList(starWars);
        }

        
        
    }

}
