using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.StudentService
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        string AdStudent(Student student);
        string UpdateStudent(Student student);
        bool DeleteStudent(int id);
    }
}
