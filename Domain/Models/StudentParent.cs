using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class StudentParent
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ParentId { get; set; }
        public string Relationship { get; set; }
    }
}
