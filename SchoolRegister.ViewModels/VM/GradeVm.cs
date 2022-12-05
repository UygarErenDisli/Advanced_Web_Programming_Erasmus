using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SchoolRegister.ViewModels.VM
{
    public class GradeVm
    {
         public Model.DataModels.GradeScale GradeValue { get; set; }= default!;
        
        
        public int? SubjectId { get; set; }= default!;  
        

        public int? StudentId { get; set; }= default!;
    }
}