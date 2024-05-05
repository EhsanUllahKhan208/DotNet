using RepoSitary.Models;

namespace RepoSitary.Repository
{
    public class StudentRepsitory : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudentById(int id)
        {
            return DataSource().Where(x => x.RollNo == id).FirstOrDefault();
        }
        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
                new StudentModel {RollNo = 1, Name = "ehsan", Gender = "M", Standard = 6 };
    }
}
