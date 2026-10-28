using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }

    public List<Course> Courses { get; } = new List<Course>();

    public Student(string name)
    {
        Name = name;
    }

    public void Join(Course course)
    {
        course.Enroll(this);
    }

    public void Leave(Course course)
    {
        course.Remove(this);
    }

    public void AddCourse(Course course)
    {
        if (!Courses.Contains(course))
        {
            Courses.Add(course);
        }
    }

    public void RemoveCourse(Course course)
    {
        Courses.Remove(course);
    }

    public void Schedule()
    {
        Console.WriteLine("\nKurser för " + Name + ":");

        if (Courses.Count == 0)
        {
            Console.WriteLine("Studenten går inte någon kurs.");
            return;
        }

        foreach (Course course in Courses)
        {
            Console.WriteLine(course);
        }
    }

    public override string ToString()
    {
        return Name;
    }
}
