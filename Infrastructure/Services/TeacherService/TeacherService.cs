using Dapper;
using Domain.Models;
using Infrastructure.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.TeacherService
{
    public class TeacherService : ITeacherService
    {
        private readonly DapperContext _context;
        public TeacherService()
        {
            _context = new DapperContext();
        }
        public string AdTeachers(Teachers teacher)
        {
            var sql = $"insert into teachers(teacherCode,teacherFullName,gender,dob,email,phone,isActive,joindate) " +
                $"values('{teacher.TeacherCode}','{teacher.FullName}','{teacher.Gender}','{teacher.Dob}','{teacher.Email}'," +
                $"'{teacher.Phone}','{teacher.IsActive}','{teacher.JoinDate}')";
            var result = _context.Connection().Execute(sql);
            if (result > 0)
            {
                return "Teacher aded";
            }
            return "Error";
        }

        public bool DeleteTeachers(int id)
        {
            var sql = $"Delete from teachers where id={@id}";
            var result = _context.Connection().Execute(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public List<Teachers> GetAllTeacherss()
        {
            var sql = "Select * from teachers";
            var result = _context.Connection().Query<Teachers>(sql).ToList();
            return result;
        }

        public Teachers GetTeachersById(int id)
        {
            var sql = $"Select * from teachers where id={@id}";
            var result = _context.Connection().QueryFirstOrDefault(sql);
            return result;
        }

        public string UpdateTeachers(Teachers teacher)
        {
            var sql = $"update teachers set teacherCode='{teacher.TeacherCode}',teacherFullName='{teacher.FullName}'," +
                $"gender='{teacher.Gender}',dob='{teacher.Dob}',email='{teacher.Email}',phone='{teacher.Phone}'," +
                $"isActive='{teacher.IsActive}',joindate='{teacher.JoinDate}' where id={teacher.Id}";
            var result = _context.Connection().Execute(sql);
            if (result > 0)
            {
                return "Teacher updated";
            }
            return "Error";
        }
    }
}
