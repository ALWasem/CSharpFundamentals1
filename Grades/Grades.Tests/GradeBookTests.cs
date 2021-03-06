﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistcs result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);

        }
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistcs result = book.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);

        }
        public void ComputesAverageGradeGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistcs result = book.ComputeStatistics();
            Assert.AreEqual(85.16, result.AverageGrade, 0.01);

        }
    }
}
