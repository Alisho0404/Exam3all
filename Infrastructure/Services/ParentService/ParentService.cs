using Dapper;
using Domain.Models;
using Infrastructure.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.ParentService
{
    public class ParentService : IParentService
    {
        private readonly DapperContext _context;
        public ParentService()
        {
            _context = new DapperContext();
        }
        public string AdParent(Parent parent)
        {
            var sql = $"insert into parents(ParentCode,ParentFullName,email,phone,createdAt)" +
                $"values('{parent.ParentCode}','{parent.ParentFullName}','{parent.Email}','{parent.Phone}','{parent.CreatedAt}')"; 
            var result=_context.Connection().Execute(sql);
            if (result>0)
            {
                return "Parent added";
            }
            return "Error";
        }

        public bool DeleteParent(int id)
        {
            var sql = $"Delete from Parents where id={@id}";
            var result= _context.Connection().Execute(sql);
            if (result>0)
            {
                return true;
            }
            return false;
        }

        public List<Parent> GetAllParents()
        {
            var sql = "Select * from parents";
            var result = _context.Connection().Query<Parent>(sql).ToList();
            return result;
        }

        public Parent GetParentById(int id)
        {
            var sql = $"Select * from parents where id={@id}";
            var result = _context.Connection().QueryFirstOrDefault(sql);
            return result;
        }

        public string UpdateParent(Parent parent)
        {
            var sql = $"update parents set ParentCode='{parent.ParentCode}',ParentFullName='{parent.ParentFullName}'," +
                $"email='{parent.Email}',phone='{parent.Phone}',createdAt='{parent.CreatedAt}' where id={parent.Id}"; 
            var result=_context.Connection().Execute(sql);
            if (result>0)
            {
                return "Parent updated";
            }
            return "Error";

        }
    }
}
