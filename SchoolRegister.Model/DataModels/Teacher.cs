using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Teacher: User
    {
        public IList<Subject> Subjects { get; set; }
        public String Title { get; set; }
        
        public Teacher() {

        }
        
    }
}