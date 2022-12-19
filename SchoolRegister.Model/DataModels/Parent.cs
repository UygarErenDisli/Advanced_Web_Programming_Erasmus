using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels

{
    public class Parent : User
    {

        public virtual IList<Student> Students { get; set; } = default!;

        public int? StudentId { get; set; } = default!;
        public virtual IList<Grade> Grades { get; set; } = default!;



        public Parent()
        {

        }

    }
}