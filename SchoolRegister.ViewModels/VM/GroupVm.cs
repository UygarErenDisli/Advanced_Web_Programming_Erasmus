using System.ComponentModel.DataAnnotations;
namespace SchoolRegister.ViewModels.VM;
public class GroupVm
{
public int Id { get; set; }
[Required]
public string Name { get; set; } = default!;
public IList<StudentVm> Students { get; set; } = default!;
public IList<SubjectVm> Subjects { get; set; } = default!;
}
