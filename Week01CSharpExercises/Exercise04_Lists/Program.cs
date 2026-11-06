using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.Write("How many numbers do you want to enter? ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }

        double average = total / (double)numbers.Count;
        int maximum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The maximum is: {maximum}");
    }
}
