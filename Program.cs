using System;

class Program
{
    static void Main()
    {
        Course mathematics = new Course("Matematik", 2);
        Course programming = new Course("Programmering", 3);

        Student anna = new Student("Anna");
        Student erik = new Student("Erik");
        Student sara = new Student("Sara");

        Console.WriteLine("=== ANMÄL STUDENTER ===");

        anna.Join(mathematics);
        erik.Join(mathematics);

        anna.Join(mathematics);

        sara.Join(mathematics);

        sara.Join(programming);

        programming.Enroll(anna);

        Console.WriteLine("\n=== KURSERNAS LISTOR ===");

        mathematics.RollCall();
        programming.RollCall();

        Console.WriteLine("\n=== STUDENTERNAS SCHEMAN ===");

        anna.Schedule();
        erik.Schedule();
        sara.Schedule();

        Console.WriteLine("\n=== KURSINFORMATION ===");

        Console.WriteLine(mathematics);
        Console.WriteLine(programming);

        Console.WriteLine("\n=== TA BORT STUDENTER ===");

        anna.Leave(mathematics);

        sara.Leave(mathematics);

        sara.Join(mathematics);

        mathematics.Remove(erik);

        Console.WriteLine("\n=== SLUTRESULTAT ===");

        mathematics.RollCall();
        programming.RollCall();

        anna.Schedule();
        erik.Schedule();
        sara.Schedule();
    }
}

