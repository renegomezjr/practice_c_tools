using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        List<float> grades;

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

    }
}
