using System;

class Program
{
    static void Main(string[] args)
    {
        // Beginning prompt.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        // Creating a new list called numbers. Declaring variable number.
        List<int> numbers = new List<int>();
        int number;

        // Do while loop to collect numbers from the user for the list.
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

        // Declaring variables for upcoming calculations and determinations.
        int sum = 0;
        int min_pos_num = int.MaxValue;

        // Calculating sum and minimum positive number by examining the list gathered from the user.
        foreach (int list_num in numbers)
        {
            sum = sum + list_num;
            if (list_num > 0 && list_num < min_pos_num)
            {
                min_pos_num = list_num;
            }
        }

        // Creating sorted list, calculating average, and determining the max number in the list.
        var sorted_set = numbers.OrderBy(num => num);
        double avg = numbers.Average();
        int max = numbers.Max();

        // Printing values for calculations in the list.
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min_pos_num}");
        Console.WriteLine("The sorted list is:");

        // Printing the sorted list of numbers.
        foreach (int value in sorted_set)
        {
            Console.WriteLine(value);
        }
    }
}