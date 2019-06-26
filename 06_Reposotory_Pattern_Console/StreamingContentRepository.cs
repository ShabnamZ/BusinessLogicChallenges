using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Reposotory_Pattern
{
    public class StreamingContentRepository
    {
       private List<StreamingContent> _listOfContent = new List<StreamingContent>();

        public void AddContentToList(StreamingContent content)
        {
            _listOfContent.Add(content);
        }

        public List<StreamingContent> GetStreamingContentList()
        {
            return _listOfContent;
        }

        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _listOfContent)
            {
                if (content.Title.ToLower() == title.ToLower()) //search through the given options to find the title asked
                {
                    return content;
                } 
            }
            return null;
        }

        public void UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            //Find the thing
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            //Apply changes to the thing
            oldContent.Title = newContent.Title;
            oldContent.Description = newContent.Description;
            oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
            oldContent.MaturityRating = newContent.MaturityRating;
            oldContent.RunTimeInMinutes = newContent.RunTimeInMinutes;
            oldContent.StarRating = newContent.StarRating;
            oldContent.TypeOfGenre = newContent.TypeOfGenre;
        }

        public  bool RemoveContentFromList(StreamingContent content)
        {
            int initialCount = _listOfContent.Count;
            _listOfContent.Remove(content);

            if (initialCount > _listOfContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
