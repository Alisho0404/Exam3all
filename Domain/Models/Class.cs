﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public int ClassroomId { get; set; }
        public string Section { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
