using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using SchoolRegister.DAL.EF;
using SchoolRegister.Model.DataModels;
using SchoolRegister.Services.Interfaces;
using SchoolRegister.ViewModels.VM;

namespace SchoolRegister.Services.ConcreteServices
{
    public class GradeService : BaseService, IGradeService
    {
        public GradeService(ApplicationDbContext dbContext, IMapper mapper, ILogger logger) : base(dbContext, mapper, logger)
        {
        }

        public GradeVm AddGradeToStudent(AddGradeToStudentVm addGradeToStudentVm)
        {
            var grade=(new Grade(){GradeValue=(GradeScale)addGradeToStudentVm.GradeValue, DateOfIssue=DateTime.Now});
            DbContext.Users.OfType<Student>().First(s0=>s0.Id==addGradeToStudentVm.StudentId).Grades.Add(grade);
            DbContext.SaveChanges();
            return Mapper.Map<GradeVm>(grade);
        }

        public GradesReportVm GetGradesReport(GetGradesReportVm getGradesReportVm)
        {
                //var grade=(new Grade(){GradeValue=(GradeScale)getGradesReportVm.});
                //DbContext.Users.OfType<Student>().First(getGradesReportVm).get(grade);
                var s = DbContext.Users.OfType<Student>().First(s=>s.Id==getGradesReportVm.StudentId).Grades;
                return new GradesReportVm(){Grades=Mapper.Map<GradeVm>(s)}

                 return Mapper.Map<GradesReportVm>(grade);

        }
        public GradesReportVm GetGradesReportForStudent(GetGradesReportVm getGradesVm)
        {
            throw new NotImplementedException();
        }
    }
    }