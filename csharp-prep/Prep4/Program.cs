using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number;
        do
        {
            Console.Write("Enter a number: ");
            string response = Console.ReadLine();
            number = int.Parse(response);
            if (number != 0)
            {
                numbers.Add(number);
            }
            

        }
        while (number != 0);
        int sum = 0;
        int min_pos_num = int.MaxValue;
        foreach (int list_num in numbers)
        {
            sum = sum + list_num;
            if (list_num > 0 && list_num < min_pos_num)
            {
                min_pos_num = list_num;
            }
        }
        var sorted_set = numbers.OrderBy(num => num);
        double avg = numbers.Average();
        int max = numbers.Max();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min_pos_num}");
        Console.WriteLine("The sorted list is:");
        foreach (int value in sorted_set)
        {
            Console.WriteLine(value);
        }
    }
}