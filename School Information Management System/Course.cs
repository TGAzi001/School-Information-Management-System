using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Course
{
    public string courseName { get; set; }
    public string courseId { get; set; }
    public int credits { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();
    public void enrollStudent(Student student)
    {
        Students.Add(student);
        Console.WriteLine($"{student.name} has been enrolled in {courseName}.");
    }

    public void dropStudent(Student student)
    {
        Students.Remove(student);
        Console.WriteLine($"{student.name} has been removed from {courseName}.");
    }

    public void getCourseInfo()
    {
        Console.WriteLine($" The {courseName}, ID: {courseId} has the following credit score: {credits}");
    }

    public bool vlidateCreditScore()
    {
        return ( credits >= 1 && credits <= 5);
    }
}
