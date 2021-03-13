using System;
/*
 * Program: The main client program 
 * Purpose: Tests out all the custom funcitons in the GenericList creatin student and professor lists
 * Coder: Sonia Friesen 0813682
 * Date: Due January 25, 2020
 */
namespace Exercises1_SF
{
    class Program
    {
        static void Main(string[] args)
        {
            //create students
            Student student_amy = new Student("Amy", "Fraser", "a_fraser@abc.com");
            Student student_matt = new Student("Matt", "Connell", "m_connell@basics.ca");
            Student student_jack = new Student("Jack", "Ryan", "j_ryan@fbi.uk");
            Student student_sara = new Student("Sara", "Jones", "s_jones@agency.ca");

            //create teachers, date is yyyy/mm/dd
            Professor mr_duncan = new Professor("Harry", "Duncan", "h_duncan@proffstar.ca", "1998/04/01");
            Professor mr_plantiff = new Professor("Mike", "Plantiff", "m_plantiff@stjohns.com", "2001/05/24");
            Professor mrs_jackson = new Professor("Jessica", "Jackson", "j_jackson@cch.ca", "2010/07/01");
            Professor mrs_whither = new Professor("Carol", "whither", "c_whither@south.com", "2020/01/01");

            //make the genericList
            GenericList<Student> students = new GenericList<Student>();
            GenericList<Professor> professors = new GenericList<Professor>();
           
            Console.WriteLine("Sonia Friesen (0813682) Exercise 1 using GenericList\n");           
            //demonstrate the add for students 
            Console.WriteLine("Testing the Add() for students list\n");            
            students.Add(student_amy);            
            students.Add(student_matt);            
            students.Add(student_jack);
            students.Add(student_sara);
            //display student
            Console.WriteLine("Displaying current students in system.\n");
            foreach(var s in students)
            {
                if (s == null)
                    break;
                else
                    Console.WriteLine(s);
            }
            Console.WriteLine();
           
            //add the professors
            Console.WriteLine("Testing the Add() for professors list\n");
            professors.Add(mr_duncan);
            professors.Add(mr_plantiff);
            professors.Add(mrs_jackson);
            professors.Add(mrs_whither);            
            //display teachers
            Console.WriteLine("Displaying current teachers in system.\n");
            foreach (var p in professors)
            {
                if (p == null)
                    break;
                else
                    Console.WriteLine(p);
            }
            Console.WriteLine();

            //using student to test function GetItem
            Console.WriteLine($"Using function GetItem() to get index 2 in students list.");
            Console.WriteLine($"{students.GetItem(2)}");
            Console.WriteLine($"\nUsing function GetItem() to get index 1 in professors list.");
            Console.WriteLine($"{professors.GetItem(1)}");
            Console.WriteLine();

            //testing the Insert method
            Console.WriteLine("Testing Insert() on students list for index 3 using a new student");
            students.Insert(3, new Student("Jonny", "Sliverhand", "j_sliverhand@cyber.ca"));
            Console.WriteLine();

            //reprint the list of students
            Console.WriteLine("Displaying current students in system.\n");
            foreach (var s in students)
            {
                if (s == null)
                    break;
                else
                    Console.WriteLine(s);
            }
            Console.WriteLine();
            //tesing the remove on students
            Console.WriteLine("Testing Remove() on students list for index 2\n");
            students.Remove(2);
            //reprint the list of students
            Console.WriteLine("Displaying current students in system.\n");
            foreach (var s in students)
            {
                if (s == null)
                    break;
                else
                    Console.WriteLine(s);
            }
            Console.WriteLine();
            //using the Clear() function
            Console.WriteLine("Using the Clear() on students list\n");
            students.Clear();
            //reprint the list of students
            Console.WriteLine("Displaying current students in system.");
            foreach (var s in students)
            {
                if (s == null)
                {
                    Console.WriteLine("Oh no, no students are in the list");
                    break;
                }
                else
                    Console.WriteLine(s);
            }
            Console.WriteLine();
            GenericList<School> school = new GenericList<School>();
            school.Add(student_sara);
            school.Add(mrs_whither);
            school.Add(student_amy);
            school.Add(mrs_jackson);
            school.Add(student_jack);
            school.Add(mr_plantiff);
            school.Add(student_matt);
            school.Add(mr_duncan);

            //print out the school results           
            Console.WriteLine("Displaying current people in the School List.\n");
            foreach (var a in school)
            {
                if (a == null)
                {                   
                    break;
                }
                else 
                    Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine("\nThanks for testing the GenericList class by Sonia Friesen 0813682");
        } 
    }
}
