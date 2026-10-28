using System;
using System.Collections.Generic;

public class Course
{
    public string Name { get; set; }
    public int MaxSeats { get; set; }

    public List<Student> Students { get; } = new List<Student>();

    public Course(string name, int maxSeats)
    {
        Name = name;
        MaxSeats = maxSeats;
    }

    public void Enroll(Student student)
    {
        if (Students.Contains(student))
        {
            Console.WriteLine(student.Name + " är redan anmäld till " + Name);
            return;
        }

        if (Students.Count >= MaxSeats)
        {
            Console.WriteLine("Kursen " + Name + " är full!");
            return;
        }

        Students.Add(student);
        student.AddCourse(this);

        Console.WriteLine(student.Name + " anmäldes till " + Name);
    }

    public void Remove(Student student)
    {
        if (Students.Remove(student))
        {
            student.RemoveCourse(this);
            Console.WriteLine(student.Name + " togs bort från " + Name);
        }
        else
        {
            Console.WriteLine(student.Name + " är inte anmäld till " + Name);
        }
    }

    public void RollCall()
    {
        Console.WriteLine("\nStuderande på kursen " + Name + ":");

        if (Students.Count == 0)
        {
            Console.WriteLine("Inga studerande.");
            return;
        }

        foreach (Student student in Students)
        {
            Console.WriteLine(student);
        }
    }

    public override string ToString()
    {
        return Name + " (" + Students.Count + "/" + MaxSeats + " platser)";
    }
}
