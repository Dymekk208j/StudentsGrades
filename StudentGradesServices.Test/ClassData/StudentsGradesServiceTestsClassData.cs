using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using StudentsGrades.Models;

namespace StudentsGrades.Test.Xunit.ClassData
{
    public class StudentsGradesServiceTestsClassData : IEnumerable<object[]>
    {
        private readonly List<Object[]> _data = new List<object[]>()
        {
            new object[]
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
            },
            new object[]
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
            }
        };
        public IEnumerator<object[]> GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
