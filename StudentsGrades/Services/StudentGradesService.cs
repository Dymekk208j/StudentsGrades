using System.Collections.Generic;
using System.Linq;
using StudentsGrades.Models;

namespace StudentsGrades.Services
{
    public  class StudentGradesService
    {
        public decimal Calculate(IEnumerable<Grade> grades)
        {
            var gradesSum = grades.Sum(a => a.Value * a.Weight);

            return gradesSum / grades.Sum(g => g.Weight);
        }
    }
}
