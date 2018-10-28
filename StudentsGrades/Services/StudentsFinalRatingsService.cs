using System;
using System.Collections.Generic;
using System.Text;
using StudentsGrades.Consts;
using StudentsGrades.Models;

namespace StudentsGrades.Services
{
    public class StudentsFinalRatingsService
    {
        private StudentsGradesAverageService _studentsGradesAverageService;
        public StudentsFinalRatingsService()
        {
            _studentsGradesAverageService = new StudentsGradesAverageService();
        }
        public int GetFinalRating(List<Grade> grades)
        {
            var average = _studentsGradesAverageService.Calculate(grades);

            if (average >= RaintingSteps.Rating6)
            {
                return 6;
            }else if (average >= RaintingSteps.Rating5)
            {
                return 5;
            }
            else if (average >= RaintingSteps.Rating4)
            {
                return 4;
            }
            else if (average >= RaintingSteps.Rating3)
            {
                return 3;
            }
            else if (average >= RaintingSteps.Rating2)
            {
                return 2;
            }
            else 
            {
                return 1;
            }
        }
    }
}
