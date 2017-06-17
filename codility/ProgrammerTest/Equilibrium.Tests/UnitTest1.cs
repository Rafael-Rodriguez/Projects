using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammerTest;

namespace Equilibrium.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Solution_NormalArray_Returns1()
        {
            //Arrange
            var array = new int[] { -1, 3, -4, 5, 1, -6, 2, 1 };
            var solution = new Solution();

            //Act
            var result = solution.solution(array);

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Solution_NormalArray_Returns2()
        {
            var array = new int[] { 1, 2, 3, 4, 3, 2, 1 };
            var solution = new Solution();

            //Act
            var result = solution.solution(array);

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Solution_EIAt0_Return0()
        {
            var array = new int[] { 1, 1, 2, 3, -3, -2, -1 };
            var solution = new Solution();

            var result = solution.solution(array);

            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Solution_EIAtEnd_ReturnNMinus1()
        {
            var array = new int[] { 1, 2, 3, -3, -2, -1, 5 };
            var solution = new Solution();

            var result = solution.solution(array);

            Assert.AreEqual(6, result);
        }
    }
}
