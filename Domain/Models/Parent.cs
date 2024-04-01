using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Parent
    {
        public int Id { get; set; }
        public string ParentCode { get; set; } 
        public string ParentFullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        
    }
}
