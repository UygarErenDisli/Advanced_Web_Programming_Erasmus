
using Microsoft.AspNetCore.Identity;
using System;

namespace SchoolRegister.Model.DataModels
{
    public class Grade
    {
        public DateTime DateOfIssue { get; set; }= default!;
        public GradeScale GradeValue { get; set; }= default!;
        public Subject Subject { get; set; }= default!;
        public int SubjectId { get; set; }= default!;
        public int StudentId { get; set; }= default!;
        public Student Student { get; set; }= default!;

        public Grade(){
            
        }
    }
}