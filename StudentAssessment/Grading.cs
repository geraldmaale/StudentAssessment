using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssessment
{
    public static class Grading
    {
        /// <summary>
        /// Get grade from marks
        /// </summary>
        /// <param name="marks">Marks of candidate or student</param>
        /// <returns>Returns a grade <see cref="char"/></returns>
        public static char GetGrade(double marks)
        {
            if (marks >= 80)
                return 'A';
            else if (marks >= 70)
                return 'B';
            else if (marks >= 60)
                return 'C';
            else if (marks >= 50)
                return 'D';
            else if (marks >= 40)
                return 'E';
            else
                return 'F';
        }

        /// <summary>
        /// Get remarks from marks
        /// </summary>
        /// <param name="marks">Marks of candidate or student</param>
        /// <returns>Returns a remarks <see cref="string"/></returns>
        public static string GetRemarks(double marks)
        {
            if (marks >= 80)
                return "Excellent";
            else if (marks >= 70)
                return "Very good";
            else if (marks >= 60)
                return "Good";
            else if (marks >= 50)
                return "Credit";
            else if (marks >= 40)
                return "Pass";
            else
                return "Fail";
        }
    }
}
