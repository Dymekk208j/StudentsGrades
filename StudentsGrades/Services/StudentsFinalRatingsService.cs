using System.Collections.Generic;
using StudentsGrades.Consts;
using StudentsGrades.Models;

namespace StudentsGrades.Services
{
    public class StudentsFinalRatingsService
    {
        private IStudentsGradesAverageService _studentsGradesAverageService;
        public StudentsFinalRatingsService(IStudentsGradesAverageService studentsGradesAverageService)
        {
            _studentsGradesAverageService = studentsGradesAverageService;
        }

        public int GetFinalRating(List<Grade> grades)
        {
            var average = _studentsGradesAverageService.Calculate(grades);

            if (average >= RatingsSteps.Rating6)
            {
                return 6;
            }else if (average >= RatingsSteps.Rating5)
            {
                return 5;
            }
            else if (average >= RatingsSteps.Rating4)
            {
                return 4;
            }
            else if (average >= RatingsSteps.Rating3)
            {
                return 3;
            }
            else if (average >= RatingsSteps.Rating2)
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
