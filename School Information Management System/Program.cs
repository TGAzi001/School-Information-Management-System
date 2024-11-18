// A School Information Management System

class Student
{
   public string name { get; set; }
   public int age { get; set; }
   public string gradeLevel { get; set; }
  public  string studentId { get; set; }

    public void enrollCourse(string course)
    {
        Console.WriteLine($"{name} has been enrolled in {course}");
    }

    public void dropCourse(string course)
    {
        Console.WriteLine($"{name} has been enrolled in {course}");
    }

    public void getstudentInfo(string studentId)
    {
        Console.WriteLine($"Hello there {name}, you are {age} years old, your Student ID is; {studentId} and you are in {gradeLevel}.");
    }

    public bool studentInfoValidatoion() 
    {
        return (age >= 13 && age <= 19) && (gradeLevel == "9" || gradeLevel == "10" || gradeLevel == "11" || gradeLevel == "12");
    }
} 