using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.TeacherService
{
    public interface ITeacherService
    {
        List<Teachers> GetAllTeacherss();
        Teachers GetTeachersById(int id);
        string AdTeachers(Teachers teacher);
        string UpdateTeachers(Teachers teacher);
        bool DeleteTeachers(int id);
    }
}
