
using Microsoft.AspNetCore.Identity;
using System;

namespace SchoolRegister.Model.DataModels
{
    public class SubjectGroup
    {
        public Subject Subject { get; set; }= default!;
        public int SubjectId { get; set; }= default!;
        public Group Group { get; set; }= default!;
        public int GroupId { get; set; }= default!;

        public SubjectGroup() {
            
        }
    }
}