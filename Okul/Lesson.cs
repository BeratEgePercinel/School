using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Priority { get; set; }
        public string Code { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<ClassLesson> ClassLessons { get; set; }
    }
}
