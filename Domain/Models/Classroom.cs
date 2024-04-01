using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Classroom
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string RoomType { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
