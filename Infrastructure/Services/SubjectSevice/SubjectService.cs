using Dapper;
using Domain.Models;
using Infrastructure.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.SubjectSevice
{
    public class SubjectService : ISubjectService
    {
        private readonly DapperContext _context;
        public SubjectService()
        {
            _context = new DapperContext();
        }
        public string AdSubject(Subject subject)
        {
            var sql = $"insert into subjects(title,schoolId,createdAt)" +
                $"values('{subject.Title}',{subject.SchoolId},'{subject.CreatedAt}')";
            var result = _context.Connection().Execute(sql);
            if (result>0)
            {
                return "Subject added";
            }
            return "Error";
        }

        public bool DeleteSubject(int id)
        {
            var sql = $"Delete from subjects where id={@id}"; 
            var result= _context.Connection().Execute(sql);
            if (result>0)
            {
                return true;
            }
            return false;
        }

        public List<Subject> GetAllSubjects()
        {
            var sql = $"Select * from Subjects";
            var result=_context.Connection().Query<Subject>(sql).ToList();
            return result;
        }

        public Subject GetSubjectById(int id)
        {
            var sql = $"Select * from Subjects where id={@id}";
            var result = _context.Connection().QueryFirstOrDefault(sql);
            return result;
        }

        public string UpdateSubject(Subject subject)
        {
            var sql = $"update subjects set title='{subject.Title}',schoolId={subject.SchoolId} ,createdAt='{subject.CreatedAt}'" +
                $"where id={subject.Id}"; 
            var result=_context.Connection().Execute(sql);
            if (result>0)
            {
                return "Subject updated";
            }
            return "Error";
        }
    }
}
