using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Branch { get; set; }
        public string PhoneNumber { get; set; }
        public string Title { get; set; }
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
        public List<ClassTeacher> ClassTeachers { get; set; }
        public List<Homework> Homeworks { get; set; }
    }
}
