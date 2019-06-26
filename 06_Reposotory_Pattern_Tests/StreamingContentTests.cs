using System;
using _06_Reposotory_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Reposotory_Pattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        private StreamingContentRepository _contentRepo;
        private StreamingContent _content;

        [TestInitialize]
        public void Arrange()
        {
           _contentRepo = new StreamingContentRepository();
           _content = new StreamingContent("Toy Story", GenreType.Bromance, "Two enemies becomes friends.", 120d, 10d, "G", true);
        }

        [TestMethod]
        public void StreamingContentUpdateTest()
        {
            //Arrange--TestInitialize
            //Act
            _contentRepo.AddContentToList(_content);

            StreamingContent newContent = new StreamingContent ("Toy Story", GenreType.Bromance, "You've got a friend in me.", 120, 5d, "G", true);
            _contentRepo.UpdateExistingContent("Toy Story", newContent);

            StreamingContent updatedContent = _contentRepo.GetContentByTitle("Toy Story");

            //Assert
            Assert.AreEqual(updatedContent.Description, newContent.Description);
        }

        

        
        [TestMethod]
        public void StreamingContentPOCOtests()
        {
            StreamingContent content = new StreamingContent("Rubber", GenreType.Horror, "The best movie ever", 125d, 5.8d, "R", false);

            Assert.AreEqual(GenreType.Horror, content.TypeOfGenre);
            Assert.AreEqual("R", content.MaturityRating);
        }

        [TestMethod]
        public void StreamingContentRepositoryAddToList()
        {
           //Arrange
            StreamingContentRepository contentRepo = new StreamingContentRepository();
            StreamingContent content = new StreamingContent("Toy Story", GenreType.Bromance, "Two enemies becomes friends.", 120d, 10d, "G", true);

            //Act
            _contentRepo.AddContentToList(content);

            int expected = 1;
            int actual = contentRepo.GetStreamingContentList().Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetContentByTitleTest()
        {
            //Arrange
            StreamingContentRepository contentRepo = new StreamingContentRepository();
            StreamingContent content = new StreamingContent("Toy Story", GenreType.Bromance, "Two enemies becomes friends.", 120d, 10d, "G", true);

            //Act
            contentRepo.AddContentToList(content);
            StreamingContent actual = contentRepo.GetContentByTitle("Toy Story");

            //Assert
            Assert.AreEqual(content, actual);

        }

        [TestMethod]
        public void RemoveFromListTest()
        {
            //Arrange
            StreamingContentRepository contentRepo = new StreamingContentRepository();
            StreamingContent content = new StreamingContent("Toy Story", GenreType.Bromance, "Two enemies becomes friends.", 120d, 10d, "G", true);

            //Act
            contentRepo.AddContentToList(content);
            bool wasRemoved = contentRepo.RemoveContentFromList(content);

            //Assert
            Assert.IsTrue(wasRemoved);
        }
        

        
    }
}


