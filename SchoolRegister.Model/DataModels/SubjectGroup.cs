using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class SubjectGroup
    {
        public Subject Subject { get; set;} = default!;
        public int SubjectId {get; set;} = default!;
        public Group Group { get; set;} = default!;
        public int GroupId {get; set;} = default!;
    }
}