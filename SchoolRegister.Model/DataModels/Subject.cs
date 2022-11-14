using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

    
namespace SchoolRegister.Model.DataModels;

    public class Subject{
        [Key]
        public int Id { get; set; }
        [Required]
        public String? Name { get; set; }
        public String? Description { get; set; }
        public virtual IList<SubjectGroup> SubjectGroups { get; set; }= default!;
        public virtual Teacher? Teacher { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }= default!;
        public virtual IList<Grade> Grades { get; set; }= default!;

        public Subject(){

        }
    }
 