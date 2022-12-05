namespace SchoolRegister.ViewModels.VM;
public class SubjectVm
{
public int Id { get; set; }
public string Name { get; set; } = default!;
public string Description { get; set; } = default!;
public IList<GroupVm> Groups { get; set; } = default!;
public string TeacherName { get; set; } = default!;
public int? TeacherId { get; set; }
}