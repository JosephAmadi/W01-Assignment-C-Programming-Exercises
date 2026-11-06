using System;

class Program
{
    static void Main()
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.Write("What is your age? ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine($"Your name is {firstName} {lastName} and you are {age} years old.");
    }
}
