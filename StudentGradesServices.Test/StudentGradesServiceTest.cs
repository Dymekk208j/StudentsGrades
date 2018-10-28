using System.Collections.Generic;
using StudentsGrades.Models;
using StudentsGrades.Services;
using StudentsGrades.Test.Xunit.ClassData;
using StudentsGrades.Test.Xunit.MemberData;
using Xunit;

namespace StudentsGrades.Test.Xunit
{
    public class StudentGradesServiceTest
    {
        [Theory]
        [ClassData(typeof(StudentsGradesServiceTestsClassData))]
        public void Calculate_ShouldReturnCorrectStatuses(List<Grade> grades, decimal expetedResult)
        {
            //Arrange

            //Act
            var result = serviceUnderTests.Calculate(grades);

            //Assert 
            Assert.Equal(expetedResult, result);
        }

        [Theory]
        [MemberData(nameof(StudentGradesServiceTest.GetGradesWithExpectedResults), MemberType = typeof(StudentGradesServiceTest))]
        public void Calculate_ShouldReturnCorrectResults_WithMemberData(List<Grade> grades, decimal expetedResult)
        {
            //Arrange

            //Act
            var result = serviceUnderTests.Calculate(grades);

            //Assert 
            Assert.Equal(expetedResult, result);
        }

        [Theory]
        [MemberData(nameof(StudentsGradesServicesTestMemberData.GetGradesWithExpectedResults), MemberType = typeof(StudentsGradesServicesTestMemberData))]
        public void Calculate_ShouldReturnCorrectResults_WithMemberDataFromOutsideClass(List<Grade> grades, decimal expetedResult)
        {
            //Arrange

            //Act
            var result = serviceUnderTests.Calculate(grades);

            //Assert 
            Assert.Equal(expetedResult, result);
        }

        [Fact]
        public void Calculate_ShouldReturnCorrectResult_4_4()
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

            //Assert 
            Assert.Equal(4.4M, result);

        }

        [Fact]
        public void Calculate_ShouldReturnCorrectResult_2_4167()
        {

            //Arrange
            var list = new List<Grade>()
            {
                new Grade()
                {
                    Value = 2.75M,
                    Weight = 1
                },
                new Grade()
                {
                    Value = 1.75M,
                    Weight = 1
                },
                new Grade()
                {
                    Value = 2.75M,
                    Weight = 1
                }
            };

            //Act
            var result = serviceUnderTests.Calculate(list);

            //Assert 
            Assert.Equal(2.4167M, result);

        }

        [Fact]
        public void Calculate_ShouldReturnCorrectResult_2_0833()
        {

            //Arrange
            var list = new List<Grade>()
            {
                new Grade()
                {
                    Value = 2.75M,
                    Weight = 1
                },
                new Grade()
                {
                    Value = 1.75M,
                    Weight = 1
                },
                new Grade()
                {
                    Value = 1.75M,
                    Weight = 1
                }
            };

            //Act
            var result = serviceUnderTests.Calculate(list);

            //Assert 
            Assert.Equal(2.0833M, result);

        }

        #region CONFIGURTAION

        private StudentsGradesAverageService serviceUnderTests;

        public StudentGradesServiceTest()
        {
            serviceUnderTests = new StudentsGradesAverageService();
        }

        public static IEnumerable<object[]> GetGradesWithExpectedResults()
        {
            yield return new object[]
            {
                new List<Grade>
                {
                    new Grade()
                    {
                        Value = 2.75M,
                        Weight = 1
                    },
                    new Grade()
                    {
                        Value = 1.75M,
                        Weight = 1
                    },
                    new Grade()
                    {
                        Value = 2.75M,
                        Weight = 1
                    }
                },
                2.4167M
            };
            yield return new object[]
            {
                new List<Grade>
                {
                    new Grade()
                    {
                        Value = 2.75M,
                        Weight = 1
                    },
                    new Grade()
                    {
                        Value = 1.75M,
                        Weight = 1
                    },
                    new Grade()
                    {
                        Value = 1.75M,
                        Weight = 1
                    }
                },
                2.0833M
            };

            #endregion

        }
    }
}