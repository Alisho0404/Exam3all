using Dapper;
using Domain.Models;
using Infrastructure.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.ClassService
{
    public class Classservice : IClassservice
    {
        private readonly DapperContext _context;
        public Classservice()
        {
            _context = new DapperContext();
        }
        public string AdClass(Class clas)
        {
            var sql = $"insert into class(className,subjectid,teacherId,classroomid,section,createdAt)" +
                $"values('{clas.ClassName}',{clas.SubjectId} ,{clas.TeacherId} ,{clas.ClassroomId},'{clas.Section}','{clas.CreatedAt}')";
            var result = _context.Connection().Execute(sql);
            if (result>0)
            {
                return "Added";
            }
            return "Error";
        }

        public bool DeleteClass(int id)
        {
            var sql = $"Delete from class where id={@id}"; 
            var result=_context.Connection().Execute(sql);
            if (result>0)
            {
                return true;
            }
            return false;
        }

        public List<Class> GetAllClasses()
        {
            var sql = "Select * from Class";
            var result= _context.Connection().Query<Class>(sql).ToList();
            return result;
        }

        public Class GetClassById(int id)
        {
            var sql = $"Select * from Class where id={@id}";
            var result = _context.Connection().QueryFirstOrDefault(sql);
            return result;

        }

        public string UpdateClass(Class clas)
        {
            var sql = $"update class set className='{clas.ClassName}',subjectid={clas.SubjectId} ,teacherId={clas.TeacherId} ," +
                $"classroomid={clas.ClassroomId} ,section='{clas.Section}',createdAt='{clas.CreatedAt}' where id={clas.Id}";
            var result=_context.Connection().Execute(sql);
            if (result>0)
            {
                return "Updated";
            }
            return "Error";
        }
    }
}
