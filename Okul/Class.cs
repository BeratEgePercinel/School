using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string President { get; set; }
        public List<ClassHomework> ClassHomeworks { get; set; }
        public List<ClassLesson> ClassLessons { get; set; }
        public List<ClassTeacher> ClassTeachers { get; set; }
        public List<Student> Students { get; set; }
    }
}
