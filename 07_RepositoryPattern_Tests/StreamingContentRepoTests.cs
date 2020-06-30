using System;
using System.Collections.Generic;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepoTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            // Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepo repository = new StreamingContentRepo();

            // Act
            bool addResult = repository.AddContentToDirectory(content);

            // Assert
            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetContents_ShouldReturnCorrectCollection()
        {
            // Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepo repository = new StreamingContentRepo();
            repository.AddContentToDirectory(content);

            // Act
            List<StreamingContent> contents = repository.GetContents();
            bool directoryHasContent = contents.Contains(content);

            // Assert
            Assert.IsTrue(directoryHasContent);            
        }

        private StreamingContentRepo _repo;
        private StreamingContent _content;
        [TestInitialize]
        public void Arrange()       //This will run at the beginning of all subsequent tests, which will save us some steps
        {
            _repo = new StreamingContentRepo();
            _content = new StreamingContent("title", "a movie", MaturityRating.PG_13, 3, GenreType.Comedy);
            _repo.AddContentToDirectory(_content);
        }

        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            // Arrange (occurs automatically now)
            // Act
            StreamingContent searchResult = _repo.GetByTitle("title");

            // Assert
            Assert.AreEqual(_content, searchResult);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            // Arrange
            StreamingContent newContent = new StreamingContent("cat", "meow", MaturityRating.G, 4, GenreType.Documentary);
            // Act
            bool updatedResult = _repo.UpdateExistingContent("title", newContent);
            // Assert
            Assert.IsTrue(updatedResult);
        }

        [TestMethod]
        public void DeleteContent_ShouldReturnTrue()
        {
            // Arrange
            StreamingContent content = _repo.GetByTitle("title");
            // Act
            bool removeResult = _repo.DeleteContent(content);
            //Assert
            Assert.IsTrue(removeResult);
        }
    }
}
