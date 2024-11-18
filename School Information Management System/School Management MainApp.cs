using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        School school = new School();

        Console.WriteLine("Welcome to the School Management System!".ToUpper());

        Console.WriteLine("How many students would you like to register?");
        int numStudents = int.Parse(Console.ReadLine());

        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"Enter details for Student below {i + 1}");

            Console.Write("Enter Student's fullname Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Student's Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Grade Level: ");
            string gradeLevel = Console.ReadLine();

            Console.Write("Enter Student's ID: ");
            string studentID = Console.ReadLine();


            Student student = new Student() { name = name, age = age, gradeLevel = gradeLevel, studentId = studentID };
            school.addStudent(student);
        }

        Console.WriteLine("____________________________________");

        Console.WriteLine("How many Treachers would you like to register?");
        int numTeachers = int.Parse(Console.ReadLine());

        for (int i = 0; i < numTeachers; i++)
        {
            Console.WriteLine($"Entering details for Teacher below{i + 1}");

            Console.Write("Enter Teacher's fullname Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Teacher's Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Department to assign teacher: ");
            string department = Console.ReadLine();

            Console.Write("Enter Teacher ID: ");
            string teacherID = Console.ReadLine();

            // Creates a new teacher and add to school record
            Teacher teacher = new Teacher() { TeacherName = name, age = age, department = department, teacherId = teacherID };
            school.addTeacher(teacher);
        }

        Console.WriteLine("____________________________________");

        Console.WriteLine("Kindly input the number of courses you would like to register");
        int numCourses = int.Parse(Console.ReadLine());

        for (int i = 0; i < numCourses; i++)
        {
            Console.WriteLine($"Entering details for Course below {i + 1}");

            Console.Write("Enter Course Name: ");
            string courseName = Console.ReadLine();

            Console.Write("Enter Course ID: ");
            string courseID = Console.ReadLine();

            Console.Write("Enter Course Credits (1-5): ");
            int credits = int.Parse(Console.ReadLine());

            Course course = new Course() { courseName = courseName, courseId = courseID, credits = credits };
            school.addCourse(course);

        }
    }
}