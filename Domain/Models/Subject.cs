﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int SchoolId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
