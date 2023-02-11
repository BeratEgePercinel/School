using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class ClassLesson
    {
        public int Id { get; set; }
        public string ClassId { get; set; }
        public Class Class { get; set; }
        public string LessonId { get; set; }
        public Lesson Lesson { get; set; }
    }
}

