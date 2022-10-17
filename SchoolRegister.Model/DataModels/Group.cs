using Microsoft.AspNetCore.Identity;
using System;
namespace SchoolRegister.Model.DataModels
{
public class Group
{
public int Id { get; set; } = default!;
public string Name { get; set; } = default!;
public IList<Student> Students { get; set; } = default!;
//public IList<SubjectGroup> SubjectGroups { get; set; }
}
}