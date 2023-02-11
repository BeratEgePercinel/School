using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class ClassHomework
    {
        public int Id { get; set; }
        public DateTime Deadline { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public int HomeworkId { get; set; }
        public Homework Homework { get; set; }
    }
}
