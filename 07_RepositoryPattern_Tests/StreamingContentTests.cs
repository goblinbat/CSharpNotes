using System;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()       // WhatAreWeTesting_ExpectedOutcome
        {
            StreamingContent content = new StreamingContent();      // to bring in StreamingContent (bc it's in a diff file): type "StreamingContent", click on it, type ctrl+. , select the option to bring it in from another file: it will then add an import line at the top of the file so we can access it here
            content.Title = "dog";

            string expected = "dog";
            string actual = content.Title;
            Assert.AreEqual(expected, actual);  // to check if it works: right click and select "run tests"; it'll throw an error if it doesn't work (or you can open the debug test menu and do it from there)
        }

        [TestMethod]
        public void SetStarRating_ShouldSetCorrectInt()
        {
            StreamingContent content = new StreamingContent();
            content.StarRating = 3;

            int expected = 3;
            int actual = content.StarRating;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetGenre_ShouldSetCorrectGenreType()
        {
            StreamingContent content = new StreamingContent();
            content.TypeOfGenre = GenreType.Horror;

            GenreType expected = GenreType.Horror;
            GenreType actual = content.TypeOfGenre;
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(GenreType.Mystery)]    // if you give the test method a parameter, the DataRow will pass it the one you give it
        [DataRow(GenreType.Thriller)]   // will run test(s) once for each DataRow
        [DataRow(GenreType.Horror)]
        public void SetGenre_ShouldSetCorrectGenre(GenreType typeOfGenre)
        {
            /// Triple A Paradigm: Arrange, Act, Assert
            // Arrange (set the stage)
            StreamingContent content = new StreamingContent();
            // Act (call the functionality you're testing
            content.TypeOfGenre = typeOfGenre;
            //Assert 
            Assert.AreEqual(typeOfGenre, content.TypeOfGenre);
        }
    }
}
