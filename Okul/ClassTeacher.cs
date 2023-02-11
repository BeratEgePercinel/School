using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class ClassTeacher
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
