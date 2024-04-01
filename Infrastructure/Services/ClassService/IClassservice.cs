using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.ClassService
{
    public interface IClassservice
    {
        List<Class> GetAllClasses();
        Class GetClassById(int id);
        string AdClass(Class clas);
        string UpdateClass(Class clas);
        bool DeleteClass(int id);
    }
}
