using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastructure.Services.SchoolService
{
    public interface ISchoolService
    {
        List<School> GetAllSchools();
        School GetSchoolById(int id);
        string AdSchool(School school);
        string UpdateSchool(School school);
        bool DeleteSchool(int id);
    }
}
