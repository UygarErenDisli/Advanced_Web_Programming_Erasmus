

namespace SchoolRegister.Model.DataModels
{
    public class Group
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public IList<Student> Students { get; set; }
        public IList<SubjectGroup> SubjectGroups { get; set; }

        public Group() {
            
        }
    }
}