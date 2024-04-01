using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.StudentParentService
{
    public interface IStudentParentService
    {
        List<StudentParent> GetAllStudentParents();
        StudentParent GetStudentParentById(int id);
        string AdStudentParent(StudentParent stp);
        string UpdateStudentParent(StudentParent stp);
        bool DeleteStudentParent(int id);
    }
}
