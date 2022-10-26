using Microsoft.AspNetCore.Identity;
using System;

namespace SchoolRegister.Model.DataModels
{
    public class Teacher: User
    {
        public IList<Subject> Subjects { get; set; }= default!;
        public String Title { get; set; }= default!;
        
        public Teacher() {

        }
        
    }
}