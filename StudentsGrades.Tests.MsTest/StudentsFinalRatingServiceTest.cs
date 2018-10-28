using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentsGrades.Models;
using StudentsGrades.Services;

namespace StudentsGrades.Tests.MsTest
{
    [TestClass]
    public class StudentsFinalRatingServiceTest 
    {
        [DataTestMethod]
        [DataRow(5.5, 6)]
        [DataRow(4.75, 5)]
        [DataRow(3.75, 4)]
        [DataRow(2.7, 3)]
        [DataRow(1.7, 2)]
        [DataRow(1.65, 1)]
        public void GetFinalRating_ShouldReturnCorrectResult(double average, int expectedResult)
        {
            //Arrange
            var serviceUnderTest = new StudentsFinalRatingsService(new StudentsGradesAverageServiceMock((decimal)average));

            //Act
            var result = serviceUnderTest.GetFinalRating(null);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }

    public class StudentsGradesAverageServiceMock  : IStudentsGradesAverageService
    {
        private readonly decimal _average;

        public StudentsGradesAverageServiceMock(decimal average)
        {
            _average = average;
        }
        public decimal Calculate(IEnumerable<Grade> grades)
        {
            return _average;
        }
    }

}
