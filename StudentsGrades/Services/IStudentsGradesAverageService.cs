using System.Collections.Generic;
using StudentsGrades.Models;

namespace StudentsGrades.Services
{
    public interface IStudentsGradesAverageService
    {
        decimal Calculate(IEnumerable<Grade> grades);
    }
}