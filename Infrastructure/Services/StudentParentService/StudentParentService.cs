using Dapper;
using Domain.Models;
using Infrastructure.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.StudentParentService
{
    public class StudentParentService : IStudentParentService
    {
        private readonly DapperContext _context;
        public StudentParentService()
        {
            _context = new DapperContext();
        }
        public string AdStudentParent(StudentParent stp)
        {
            var sql = $"insert into studentParent(studentid,parentId,relationship)" +
                $"values({stp.StudentId},{stp.ParentId},'{stp.Relationship}')";
            var result = _context.Connection().Execute(sql);
            if (result>0)
            {
                return "Added";
            }
            return "Error";
        }

        public bool DeleteStudentParent(int id)
        {
            var sql = $"Delete from studentParent where id={@id}";
            var result= _context.Connection().Execute(sql); 
            if (result>0)
            {
                return true;
            }
            return false;
        }

        public List<StudentParent> GetAllStudentParents()
        {
            var sql = $"Select * from studentParent";
            var result = _context.Connection().Query<StudentParent>(sql).ToList();
            return result;
        }

        public StudentParent GetStudentParentById(int id)
        {
            var sql = $"Select * from studentParent where id={@id}";
            var result = _context.Connection().QueryFirstOrDefault(sql);
            return result;
        }

        public string UpdateStudentParent(StudentParent stp)
        {
            var sql = $"update studentparent set studentid={stp.StudentId} ,parentId={stp.ParentId} ,relationship='{stp.Relationship}'" +
                $"where id={stp.Id}";
            var result=_context.Connection().Execute(sql);
            if (result>0)
            {
                return "Updated";
            }
            return "Error";
        }
    }
}
