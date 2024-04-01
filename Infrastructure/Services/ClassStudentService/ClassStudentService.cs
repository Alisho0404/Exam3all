using Dapper;
using Domain.Models;
using Infrastructure.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.ClassStudentService
{
    public class ClassStudentService : IClassStudentService
    {
        private readonly DapperContext _context;
        public ClassStudentService()
        {
            _context = new DapperContext();
        }
        public string AdClassStudent(ClassStudent cs)
        {
            var sql = $"insert into classStudent(classId,studentid)" +
                $"values({cs.ClassId},{cs.StudentId})";
            var result = _context.Connection().Execute(sql);
            if (result>0)
            {
                return "Added";
            }
            return "Error";
        }

        public bool DeleteClassStudent(int id)
        {
            var sql = $"Delete from classStudent where id={@id}";
            var result= _context.Connection().Execute(sql);
            if (result>0)
            {
                return true;
            }
            return false;
        }

        public List<ClassStudent> GetAllClassStudents()
        {
            var sql = "Select * from classStudent";
            var result = _context.Connection().Query<ClassStudent>(sql).ToList();
            return result;
        }

        public ClassStudent GetClassStudentById(int id)
        {
            var sql = $"Select * from classStudent where id={@id}";
            var result = _context.Connection().QueryFirstOrDefault(sql);
            return result;
        }

        public string UpdateClassStudent(ClassStudent cs)
        {
            var sql = $"update classStudent set classId={cs.ClassId} ,studentid={cs.StudentId} where id={cs.Id}"; 
            var result=_context.Connection().Execute(sql);
            if (result>0)
            {
                return "Updated";
            }
            return "Error";
        }
    }
}
