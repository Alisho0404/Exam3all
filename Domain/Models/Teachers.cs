using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Teachers
    {
        public int Id { get; set; }
        public required string TeacherCode { get; set; }
        public required string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string IsActive { get; set; }
        public DateTime JoinDate { get; set; }
        
    }
}
