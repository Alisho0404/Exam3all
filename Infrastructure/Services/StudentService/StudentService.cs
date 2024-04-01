using Dapper;
using Domain.Models;
using Infrastructure.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.StudentService
{
    public class StudentService : IStudentService
    {
        private readonly DapperContext _context;
        public StudentService()
        {
            _context = new DapperContext();
        }
        public string AdStudent(Student student)
        {
            var sql = $"insert into students(studentCode,studentfullname,gender,DOB,email,phone,schoolId,IsActive,joinDate)" +
                $"values('{student.StudentCode}','{student.Studentfullname}','{student.Gender}','{student.Dob}','{student.Email}'," +
                $"'{student.Phone}',{student.SchoolId} ,'{student.IsActive}','{student.JoinDate}') ";
            var result = _context.Connection().Execute(sql);
            if (result>0)
            {
                return "Student added";
            }
            return "Error";
        }

        public bool DeleteStudent(int id)
        {
            var sql = $"Delete from students where id={@id}";
            var result= _context.Connection().Execute(sql);
            if (result>0)
            {
                return true;
            }
            return false;
        }

        public List<Student> GetAllStudents()
        {
            var sql = $"Select * from students";
            var result=_context.Connection().Query<Student>(sql).ToList();
            return result;
        }

        public Student GetStudentById(int id)
        {
            var sql = $"Select * from students where id={@id}";
            var result = _context.Connection().QueryFirstOrDefault(sql);
            return result;
        }

        public string UpdateStudent(Student student)
        {
            var sql = $"update students set studentCode='{student.StudentCode}',studentfullname='{student.Studentfullname}'," +
                 $"gender='{student.Gender}',DOB='{student.Dob}',email='{student.Email}',phone='{student.Phone}',schoolId={student.SchoolId}," +
                 $"IsActive='{student.IsActive}',joinDate='{student.JoinDate}' where id={student.Id}"; 
            var result=_context.Connection().Execute(sql);
            if (result>0)
            {
                return "Student updated";
            } 
            return "Error";
        }
    }
}
