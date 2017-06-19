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

        [TestMethod]
        public void Solution_Extreme_Negative_Numbers_ReturnNeg1()
        {
            var array = new int[] { 0, -2147483648, -2147483648 };
            var solution = new Solution();

            var result = solution.solution(array);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Solution_Extreme_Positive_Numbers_ReturnNeg1()
        {
            var array = new int[] { 2147483647, 2147483647,  1};
            var solution = new Solution();

            var result = solution.solution(array);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Solution_LargeLongSequenceOfOnes_ReturnWithin310msecs()
        {
            const int length = 10000;
            int[] array = new int[length];
            for(int i = 0; i < length; ++i)
            {
                array[i] = 1;
            }

            var solution = new Solution();

            var currentTime = DateTime.Now;

            var result = solution.solution(array);

            var timeAfter = DateTime.Now;

            Assert.IsTrue(timeAfter - currentTime < TimeSpan.FromSeconds(0.30));

        }
    }
}
