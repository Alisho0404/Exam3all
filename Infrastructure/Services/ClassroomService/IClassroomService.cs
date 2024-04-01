using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastructure.Services.ClassroomService
{
    public interface IClassroomService
    {
        List<Classroom> GetAllClassrooms(); 
        Classroom GetClassroomById(int id);
        string AddClasroom(Classroom classroom);
        string UpdateClassroom(Classroom classroom); 
        bool DeleteClassroom(int id);
    }
}
