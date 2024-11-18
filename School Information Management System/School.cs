using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class  School
{
    public List<Student> Students { get; set; } = new List<Student>();
    public List<Teacher> Teachers { get; set; } = new List<Teacher>();
    public List<Course> Courses { get; set; } = new List<Course>();
    public List<Grade> Grades { get; set; } = new List<Grade>();

    public void addStudent(Student student)
    {
        Students.Add(student);
        Console.WriteLine($"Student {student.name} has been added.");
    }
    public void addTeacher(Teacher teacher)
    {
        Teachers.Add(teacher);
        Console.WriteLine($"Teacher {teacher.TeacherName} has been added.");
    }
    public void addCourse(Course course)
    {
        Courses.Add(course);
        Console.WriteLine($"Course {course.courseName} has been added.");
    }
    public void displaySchoolInfo()
    {
        Console.WriteLine("This is the School Info:\n");
     
    }
}
