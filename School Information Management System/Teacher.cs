using System;

public class Teacher
{

   public string TeacherName { get; set; }
    public int age { get; set; }
    public string department { get; set; }
    public string teacherId { get; set; }

    public void assignCourse(string course)
    {
        Console.WriteLine($"Good day Teacher {TeacherName} you have been assigned {course} to handle, thankyou.");
    }

    public void removeCourse(string course)
    {
        Console.WriteLine($"Good day Teacher {TeacherName} you are no longer to take the {course}");
    }

    public void getTeacherInfo(string course)
    {
        Console.WriteLine($"Good day Teacher {TeacherName} you are {age} years old, you are in the {department} department and are to handle the {course}.");
    }
    public bool teacherInfoValidation()
    {
        return (age >= 25 && age <= 60);
    }
}
