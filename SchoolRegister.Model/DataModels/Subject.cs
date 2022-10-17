using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Subject
    {
        public int Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public IList<SubjectGroup> SubjectGroups { get; set; } = default!;
        public Teacher Teacher {get; set; } = default!;
        public int? TeacherId { get; set; } = default!;
        public IList<Grade> Grades {get; set; } = default!;
    }
}
