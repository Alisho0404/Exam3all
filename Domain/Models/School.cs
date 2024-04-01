using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class School
    {
        public int Id { get; set; }
        public string SchoolTitle { get; set; }
        public int LevelCount { get; set; }
        public string IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
