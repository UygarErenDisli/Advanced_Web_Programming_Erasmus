using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Student
    {
        public Group Group { get; set; }
        public int? GroupId { get; set; }
        public IList<Grade> Grades { get; set; }
        public Parent Parent { get; set; }
        public int? ParentId { get; set; }
        public double AverageGrade { get; }
        public IDictionary<String, Double> AverageGradePerSubject { get; }
        public IDictionary<String, List<GradeScale>> GradesPerSubject { get; }

        public Student() {
            
        }

    }
}