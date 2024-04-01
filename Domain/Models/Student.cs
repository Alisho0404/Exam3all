using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentCode { get; set; }
        public string Studentfullname { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int SchoolId { get; set; }
        public string IsActive { get; set; }
        public DateTime JoinDate { get; set; }

    }
}
