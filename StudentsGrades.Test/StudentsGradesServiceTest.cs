using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentsGrades.Models;
using StudentsGrades.Services;

namespace StudentsGrades.Test
{
    [TestClass]
    public class StudentsGradesServiceTest
    {
        [TestMethod]
        public void Calculate_ShouldReturnCorrectResult()
        {

            //Arrange
            var list = new List<Grade>()
            {
                new Grade()
                {
                    Value = 5,
                    Weight = 2
                },
                new Grade()
                {
                    Value = 4,
                    Weight = 3
                }
            };

            //Act
            var result = serviceUnderTests.Calculate(list);

            //Arrange 
            Assert.AreEqual(4.4M, result);

        }
        #region CONFIGURTAION
        private StudentGradesService serviceUnderTests;

        public StudentsGradesServiceTest()
        {
            serviceUnderTests = new StudentGradesService();
        }

        #endregion
    }
}
