using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void solution_a0ba_ReturnMinus1()
        {
            var solution = new Solution();

            var result = solution.solution("a0ba");

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void solution_a0Ba_Return2()
        {
            //Arrange
            var solution = new Solution();

            //Act
            var result = solution.solution("a0Ba");

            //Assert
            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void solution_a0BaBa2_Return4()
        {
            //Arrange
            var solution = new Solution();

            //Act
            var result = solution.solution("a0BaBa2");

            //Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void solution_Ba0Ba2_Return2()
        {
            //Arrange
            var solution = new Solution();

            //Act
            var result = solution.solution("Ba0Ba2");

            //Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void solution_100character_Return100()
        {
            //Arrange
            var solution = new Solution();

            //Act
            var result = solution.solution("a0BABABABABABABABABABABABABABABABABABABABABABABABABABABABABABABABABABABABABABABABABABABABABABABABABABA8b");

            //Assert
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void solution_a0BABAB7ABaziga8b_Return7()
        {
            //Arrange
            var solution = new Solution();

            //Act
            var result = solution.solution("a0BABAB7ABaziga8b");

            //Assert
            Assert.AreEqual(7, result);
        }

    }
}
