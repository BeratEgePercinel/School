# School

Let's design a school database. Design the database of Kadıköy Anatolian High School. The courses in the school have a name, code and degree of importance. There are teachers, teachers have names, surnames, branches, phone numbers, and titles. There are students. Students have name, surname, class, tcsi, age There is a class There is a class name, capacity and a president (a normal variable in student type?) there are. Each class has lessons. A course can be taught by more than one teacher. Students can be in a classroom. There are teachers in the classroom. Homework is given at school. Assignments have a name, code, and deadline. An assignment can be assigned to multiple classes. A teacher prepares the homework and gives homework to many classes.

The following solution has been produced for the above problem

![image](https://user-images.githubusercontent.com/119699844/218275278-83f74f8d-0100-464e-bc9d-f21059017500.png)

CREATE TABLE Class (
	Id int PRIMARY KEY IDENTITY (1,1),
	Name varchar(250),
	Capacity int,
	President varchar(250)
);

CREATE TABLE Lesson (
	Id int PRIMARY KEY IDENTITY (1,1),
	Name varchar(250),
	Priority varchar(250),
	Code int
);

CREATE TABLE Student (
	Id int PRIMARY KEY IDENTITY (1,1),
	Name varchar(250),
	Surname varchar(250),
	Tc int,
	Age varchar(250),
	ClassId int NOT NULL,
	FOREIGN KEY (ClassId) REFERENCES Class(Id),
);

CREATE TABLE Teacher (
	Id int PRIMARY KEY IDENTITY (1,1),
	Name varchar(250),
	Surname varchar(250),
	Branch varchar(250),
	PhoneNumber int,
	Title varchar(250),
	LessonId int NOT NULL,
	FOREIGN KEY (LessonId) REFERENCES Lesson(Id),
);

CREATE TABLE Homework (
	Id int PRIMARY KEY IDENTITY (1,1),
	Name varchar(250),
	Subject varchar(250),
	TeacherId int NOT NULL,
	FOREIGN KEY (TeacherId) REFERENCES Teacher(Id),
);

CREATE TABLE ClassHomework (
	Id int PRIMARY KEY IDENTITY (1,1),
	ClassId int NOT NULL,
	HomeworkId int NOT NULL,
	Deadline DateTime,
	FOREIGN KEY (ClassId) REFERENCES Class(Id),
	FOREIGN KEY (HomeworkId) REFERENCES Homework(Id),
);

CREATE TABLE ClassLesson (
	Id int PRIMARY KEY IDENTITY (1,1),
	ClassId int NOT NULL,
	LessonId int NOT NULL,
	FOREIGN KEY (ClassId) REFERENCES Class(Id),
	FOREIGN KEY (LessonId) REFERENCES Lesson(Id),
);

CREATE TABLE ClassTeacher (
	Id int PRIMARY KEY IDENTITY (1,1),
	ClassId int NOT NULL,
	TeacherId int NOT NULL,
	FOREIGN KEY (ClassId) REFERENCES Class(Id),
	FOREIGN KEY (TeacherId) REFERENCES Teacher(Id),
);

INSERT INTO Class (Name, Capacity, President)
VALUES ('1A', 10, 'Mehmet');
INSERT INTO Class (Name, Capacity, President)
VALUES ('1B', 20, 'Salih');
INSERT INTO Class (Name, Capacity, President)
VALUES ('1C', 30, 'Nazım');
INSERT INTO Class (Name, Capacity, President)
VALUES ('1D', 40, 'Yılmaz');
INSERT INTO Class (Name, Capacity, President)
VALUES ('1E', 50, 'Ahmet');

INSERT INTO Lesson (Name, Priority, Code)
VALUES ('Mat', 1, 1);
INSERT INTO Lesson (Name, Priority, Code)
VALUES ('Tr', 2, 2);
INSERT INTO Lesson (Name, Priority, Code)
VALUES ('Sos', 3, 3);
INSERT INTO Lesson (Name, Priority, Code)
VALUES ('Fel', 4, 4);
INSERT INTO Lesson (Name, Priority, Code)
VALUES ('Fen', 5, 5);

INSERT INTO Student (Name, Surname, Tc, Age, ClassId)
VALUES ('Ahmet', 'Yılmaz', 10, 17, 1);
INSERT INTO Student (Name, Surname, Tc, Age, ClassId)
VALUES ('Mehmet', 'Nazım', 20, 16, 2);
INSERT INTO Student (Name, Surname, Tc, Age, ClassId)
VALUES ('Alp', 'Tekin', 20, 16, 2);
INSERT INTO Student (Name, Surname, Tc, Age, ClassId)
VALUES ('Salih', 'Başaran', 40, 15, 4);
INSERT INTO Student (Name, Surname, Tc, Age, ClassId)
VALUES ('Namık', 'Ekin', 50, 17, 5);

INSERT INTO Teacher (Name, Surname, Branch, PhoneNumber, Title, LessonId)
VALUES ('A', 'A', 'Mat', 121, 'Hoca', 1);
INSERT INTO Teacher (Name, Surname, Branch, PhoneNumber, Title, LessonId)
VALUES ('B', 'B', 'Fen', 122, 'Müdür', 2);
INSERT INTO Teacher (Name, Surname, Branch, PhoneNumber, Title, LessonId)
VALUES ('C', 'C', 'Fiz', 123, 'M. Yarıdımcısı', 3);
INSERT INTO Teacher (Name, Surname, Branch, PhoneNumber, Title, LessonId)
VALUES ('D', 'D', 'Tr', 124, 'M. Yardımcısı', 4);
INSERT INTO Teacher (Name, Surname, Branch, PhoneNumber, Title, LessonId)
VALUES ('E', 'E', 'Sos', 125, 'Hoca', 5);

INSERT INTO Homework (Name, Subject, TeacherId)
VALUES ('Haftasonu', 'Mat', 1);
INSERT INTO Homework (Name, Subject, TeacherId)
VALUES ('Haftaiçi', 'Biyo', 2);
INSERT INTO Homework (Name, Subject, TeacherId)
VALUES ('Tatil', 'Kimya', 3);
INSERT INTO Homework (Name, Subject, TeacherId)
VALUES ('Tatil', 'Fiz', 4);
INSERT INTO Homework (Name, Subject, TeacherId)
VALUES ('Haftasonu', 'Sos', 5);

INSERT INTO ClassHomework (ClassId, HomeworkId, Deadline)
VALUES (2, 1, 2023);
INSERT INTO ClassHomework (ClassId, HomeworkId, Deadline)
VALUES (2, 2, 2023);
INSERT INTO ClassHomework (ClassId, HomeworkId, Deadline)
VALUES (3, 2, 2023);
INSERT INTO ClassHomework (ClassId, HomeworkId, Deadline)
VALUES (4, 5, 2023);
INSERT INTO ClassHomework (ClassId, HomeworkId, Deadline)
VALUES (4, 5, 2023);

INSERT INTO ClassTeacher (ClassId, TeacherId)
VALUES (2, 5);
INSERT INTO ClassTeacher (ClassId, TeacherId)
VALUES (4, 1);
INSERT INTO ClassTeacher (ClassId, TeacherId)
VALUES (2, 3);
INSERT INTO ClassTeacher (ClassId, TeacherId)
VALUES (1, 4);
INSERT INTO ClassTeacher (ClassId, TeacherId)
VALUES (5, 1);

INSERT INTO ClassLesson (ClassId, LessonId)
VALUES (1, 3); 					 
INSERT INTO ClassLesson (ClassId, LessonId)
VALUES (3, 2);					
INSERT INTO ClassLesson (ClassId, LessonId)
VALUES (4, 1); 					 
INSERT INTO ClassLesson (ClassId, LessonId)
VALUES (2, 5); 				
INSERT INTO ClassLesson (ClassId, LessonId)
VALUES (5, 4);

--1. The homeworks which has given to 1A

SELECT Homework.Name FROM Class, ClassHomework, Homework
WHERE Class.Id = ClassHomework.ClassId
AND   Homework.Id =  ClassHomework.HomeworkId
AND   Class.Name = '1B' 

--2. The students who tooks math lessons

SELECT Student.Name, Class.Name FROM Lesson, ClassLesson, Class, Student
WHERE Lesson.Id = ClassLesson.LessonId
AND   Class.Id = ClassLesson.ClassId
AND   Student.Id = Class.Id
AND   Lesson.Name = 'Mat'

--3. The names of the lessons which contains the classes that contains Alp Tekin 


SELECT Lesson.Name FROM Student, Class, ClassHomework, Homework, Teacher, Lesson
WHERE Student.ClassId = Class.Id
AND   Class.Id = ClassHomework.ClassId
AND   Homework.Id = ClassHomework.HomeworkId
AND   Teacher.Id = Homework.TeacherId
AND   Lesson.Id = Teacher.LessonId
AND   Student.Name = 'Alp'
