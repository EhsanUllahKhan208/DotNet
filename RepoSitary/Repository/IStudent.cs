using RepoSitary.Models;

namespace RepoSitary.Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudents();
        StudentModel getStudentById(int id);

    }
}
