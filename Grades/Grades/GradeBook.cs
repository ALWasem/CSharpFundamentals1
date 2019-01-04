using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook : GradeTracker
    {

        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();

        }

        public override GradeStatistcs ComputeStatistics()
        {
            GradeStatistcs stats = new GradeStatistcs();


            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;

            return stats;
        }

        internal override void WriteGrades(TextWriter destination)
        {
            for (int i = grades.Count - 1; i > 0; i--)
            {
                destination.WriteLine(grades[i]);
            }
        }

        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public override IEnumerator GetEnumerator()
        {
            return grades.GetEnumerator();
        }

        protected List<float> grades;
    }

}
