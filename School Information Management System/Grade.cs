using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Grade
{
    public string studentId {  get; set; }
    public string courseId { get; set; }  
    public string gradeValue { get; set; }

    public double calculateGpa()
    {
        switch (gradeValue.ToUpper()) 
        {
            case "A": return 4.0;
            case "B": return 3.0;
            case "C": return 2.0;
            case "D": return 1.0;
            case "F": return 0.0;

            default: throw new ArgumentException("Invalid grade value");
        }
    }

    public void getGradeInfo()
    {
        Console.WriteLine($"Good day student {studentId}, your course ID is {courseId} and this is your Grade {gradeValue}");
    }

    public bool validateGrade()
    {
        return ( gradeValue == "A" || gradeValue == "B" || gradeValue == "C" || gradeValue == "D" || gradeValue == "E" || gradeValue == "F");
    }
}

