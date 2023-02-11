using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TC { get; set; }
        public string Age { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
}
