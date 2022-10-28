using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolRegister.Model.DataModels
{
    public class Group
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public String? Name { get; set; }
        public virtual IList<Student> Students { get; set; }
        public IList<SubjectGroup> SubjectGroups { get; set; } = default!;

        public Group(){
            
    }
    }
}