using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.ClassStudentService
{
    public interface IClassStudentService
    {
        List<ClassStudent> GetAllClassStudents();
        ClassStudent GetClassStudentById(int id);
        string AdClassStudent(ClassStudent cs);
        string UpdateClassStudent(ClassStudent cs);
        bool DeleteClassStudent(int id);
    }
}
