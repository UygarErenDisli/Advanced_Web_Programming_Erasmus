using Microsoft.AspNetCore.Identity;
using System;
    
namespace SchoolRegister.Model.DataModels
{
    public class Subject{
        
        public int Id { get; set; }
        public String? Name { get; set; }
        public String? Description { get; set; }
        public IList<SubjectGroup> SubjectGroups { get; set; }= default!;
        public Teacher? Teacher { get; set; }
        public int TeacherId { get; set; }= default!;
        public IList<Grade> Grades { get; set; }= default!;

        public Subject(){

        }
    }
 }