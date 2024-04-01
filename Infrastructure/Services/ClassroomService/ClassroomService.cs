using Dapper;
using Domain.Models;
using Infrastructure.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.ClassroomService
{
    public class ClassroomService : IClassroomService
    {
        private readonly DapperContext _context;
        public ClassroomService()
        {
            _context = new DapperContext();
        }
        public string AddClasroom(Classroom classroom)
        {
            var sql = $"insert into clasrooms(capacity,roomtype,description,createdAt)" +
                $"values({classroom.Capacity},'{classroom.RoomType}','{classroom.Description}','{classroom.CreatedAt}')";
            var result = _context.Connection().Execute(sql);
            if (result>0)
            {
                return "Added class";
            }
            return "Error";
        }

        public bool DeleteClassroom(int id)
        {
            var sql = $"Delete from clasrooms where id={@id}";
            var result= _context.Connection().Execute(sql);
            if (result>0)
            {
                return true;
            }
            return false;
        }

        public List<Classroom> GetAllClassrooms()
        {
            var sql = $"Select * from clasrooms";
            var result=_context.Connection().Query<Classroom>(sql).ToList();
            return result;
        }

        public Classroom GetClassroomById(int id)
        {
            var sql = $"Select * from clasrooms where id={@id}";
            var result = _context.Connection().QueryFirstOrDefault(sql);
            return result;
        }

        public string UpdateClassroom(Classroom classroom)
        {
            var sql = $"update clasrooms set capacity={classroom.Capacity} ,roomtype='{classroom.RoomType}'," +
                $"description='{classroom.Description}',createdAt='{classroom.CreatedAt}' where id ={classroom.Id}"; 
            var result=_context.Connection().Execute(sql);
            if (result>0)
            {
                return "Updated";
            }
            return "Error";
        }
    }
}
