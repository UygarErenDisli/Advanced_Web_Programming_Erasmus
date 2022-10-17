using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Grade
    {
    public DateTime DateOfIssue { get; set; }
    public GradeScale GradeValue { get; set; } = default!;
    public Subject Subject { get; set; } = default!;
    public int SubjectId { get; set; } = default!;
    public int StudentId { get; set; } = default!;

    }
}