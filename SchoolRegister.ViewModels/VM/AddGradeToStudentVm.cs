using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.ViewModels.VM
{
    public class AddGradeToStudentVm
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public object? GradeValue { get; set; }
        public int TeacherId { get; set; }
    }
}