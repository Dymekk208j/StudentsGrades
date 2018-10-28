using System;
using System.Collections.Generic;
using System.Text;
using StudentsGrades.Models;

namespace StudentsGrades.Test.Xunit.MemberData
{
    public class StudentsGradesServicesTestMemberData
    {
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


        }
    }
}
