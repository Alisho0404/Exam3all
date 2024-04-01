using Dapper;
using Domain.Models;
using Infrastructure.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.SchoolService
{
    public class SchoolService : ISchoolService
    {
        private readonly DapperContext _context;
        public SchoolService()
        {
            _context = new DapperContext();
        }
        public string AdSchool(School school)
        {
            var sql = $"insert into schools(schoolTitle,levelCount,isActive,createdAt)" +
                $"values('{school.SchoolTitle}',{school.LevelCount} ,'{school.IsActive}','{school.CreatedAt}')"; 
            var res=_context.Connection().Execute(sql) ;
            if (res>0)
            {
                return "School added";
            }
            return "Error";
        }

        public bool DeleteSchool(int id)
        {
            var sql = $"Delete from school where id={@id}"; 
            var res= _context.Connection().Execute(sql) ;
            if (res>0)
            {
                return true;
            }
            return false;
        }

        public List<School> GetAllSchools()
        {
            var sql = $"Select * from School";
            var res=_context.Connection().Query<School>(sql).ToList();
            return res;
        }

        public School GetSchoolById(int id)
        {
            var sql = $"Select * from School where id={@id}";
            var res = _context.Connection().QueryFirstOrDefault(sql);
            return res;
        }

        public string UpdateSchool(School school)
        {
            var sql = $"update schools set schoolTitle='{school.SchoolTitle}',levelCount={school.LevelCount}," +
                $"isActive='{school.IsActive}',createdAt='{school.CreatedAt}' where id={school.Id}";
            var res=_context.Connection().Execute(sql) ;
            if (res>0)
            {
                return "School updated";
            }
            return "Error";
        }
    }
}
