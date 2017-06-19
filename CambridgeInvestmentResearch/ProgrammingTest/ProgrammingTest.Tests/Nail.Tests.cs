using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingTest.Tests
{
	/// <summary>
	/// Summary description for Nail
	/// </summary>
	[TestClass]
	public class NailTests
	{
		[TestMethod]
		public void SolutionNails_3NailsOfLength3HammerIn2_ResultOf5()
		{
			//Arrange
            var solutionNails = new SolutionNails();
            var array = new int[] { 1, 1, 3, 3, 3, 4, 5, 5, 5, 5 };

            //Act
            var result = solutionNails.solution(array, 2);

            //Assert
            Assert.AreEqual(5, result);
		}

        [TestMethod]
        public void SolutionNails_2NailsOfLength1HammerIn1_ResultOf3()
        {
            //Arrange
            var solutionNails = new SolutionNails();
            var array = new int[] { 1, 1, 3, 4, };

            //Act
            var result = solutionNails.solution(array, 1);

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SolutionNails_2NailsOfLength1HammerIn4Only3Nails_ResultOf0()
        {
            //Arrange
            var solutionNails = new SolutionNails();
            var array = new int[] { 1, 1, 3 };

            //Act
            var result = solutionNails.solution(array, 4);

            //Assert
            Assert.AreEqual(3, result);
        }
    }
}
