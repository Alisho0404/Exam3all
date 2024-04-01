using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.SubjectSevice
{
    public interface ISubjectService
    {
        List<Subject> GetAllSubjects();
        Subject GetSubjectById(int id);
        string AdSubject(Subject subject);
        string UpdateSubject(Subject subject);
        bool DeleteSubject(int id);
    }
}
