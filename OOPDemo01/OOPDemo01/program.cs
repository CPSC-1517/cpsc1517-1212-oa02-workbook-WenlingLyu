using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPDemo01;
using static System.Console;//Allows you to access the static methods in Console class direction

Course cpsc1517Course = new Course("CPSC1517", "Introduction to Application Development");
//var cpsc1517Course = new Course("CPSC1517", "Introduction to Application Development");
//Course cpsc1517Course = new Course("CPSC1517", "Introduction to Application Development");
/*
WriteLine($"CourseNo:{cpsc1517Course.CourseNo}");
WriteLine($"CourseName:{cpsc1517Course.CourseName}");
*/
//Add some students to the course
/*
cpsc1517Course.AddStudent("Aron Fong");
cpsc1517Course.AddStudent("Wenling Lyu");
cpsc1517Course.AddStudent("Hamza Said");
cpsc1517Course.AddStudent("Sam Wu");
cpsc1517Course.AddStudent("Willow Liu");
**/

//Should have a @ for the filepath
cpsc1517Course.LoadFromFile(@"D:\CPSC1517\Git-CPSC1517\students.txt");

//Display all the students in the course
foreach (var currentStudent in cpsc1517Course.Students)
{
    WriteLine(currentStudent);
}

//Remove 2 students from the course
cpsc1517Course.RemoveStudent("Aron Fong");
cpsc1517Course.RemoveStudent("Hamza Said");

//Display the number of students
WriteLine($"There are now {cpsc1517Course.StudentCount} students");
//Try 

