using System;
using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool loop = true;
        while (loop)
        {
            Console.Clear();
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            if (int.TryParse(Console.ReadLine(), out int option))
            {
                if (option == 1)
                {

                }
                else if (option == 2)
                {

                }
                else if (option == 3)
                {

                }
                else if (option == 4)
                {

                }
                else if (option == 5)
                {

                }
                else if (option == 6)
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please choose an option between 1-6.");
                    Thread.Sleep(2000);
                }
            }
            else
            {
                Console.WriteLine("Invalid Input. Please choose an option between 1-6.");
                Thread.Sleep(2000);
            }


        }
    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {

    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}