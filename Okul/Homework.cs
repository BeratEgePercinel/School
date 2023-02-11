using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Homework
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public DateTime Deadline { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public List<ClassHomework> ClassHomeworks { get; set; }
    }
}
