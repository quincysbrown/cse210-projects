using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;
        while (loop)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu:");
            if (int.TryParse(Console.ReadLine(), out int option))
            {
                if (option == 1)
                {
                    //start breathing activity.
                    BreathingActivity breathe = new BreathingActivity();
                    breathe.Run();
                }
                else if (option == 2)
                {
                    //start reflecting activity.
                    ReflectingActivity reflect = new ReflectingActivity();
                    reflect.Run();
                }
                else if (option == 3)
                {
                    //start listing activity.
                    ListingActivity list = new ListingActivity();
                    list.Run();
                }
                else if (option == 4)
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
                else
                {
                    Console.WriteLine("Error. Please choose an option between 1-4.");
                    Thread.Sleep(2000);
                }
            }
            else
            {
                Console.WriteLine("Error. Please choose an option between 1-4.");
                Thread.Sleep(2000);
            }


        }
    }
}