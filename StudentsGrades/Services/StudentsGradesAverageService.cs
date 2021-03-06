﻿using System;
using System.Collections.Generic;
using System.Linq;
using StudentsGrades.Models;

namespace StudentsGrades.Services
{
    public  class StudentsGradesAverageService : IStudentsGradesAverageService
    {
        public decimal Calculate(IEnumerable<Grade> grades)
        {
            var gradesSum = grades.Sum(a => a.Value * a.Weight);

            return Math.Round(gradesSum / grades.Sum(g => g.Weight), 4);
        }
    }
}
