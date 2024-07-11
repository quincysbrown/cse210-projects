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
        Console.Clear();
        bool loop = true;
        while (loop)
        {
            Console.WriteLine();
            DisplayPlayerInfo();
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
                    CreateGoal();
                }
                else if (option == 2)
                {
                    Console.WriteLine("The goals are:");
                    ListGoalDetails();
                }
                else if (option == 3)
                {

                }
                else if (option == 4)
                {

                }
                else if (option == 5)
                {
                    Console.WriteLine("The Goals are:");
                    ListGoalNames();
                    RecordEvent();
                    Console.WriteLine($"You now have {_score} points.");
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
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        int num = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{num}. {goal.GetName()}");
            num++;
        }
    }

    public void ListGoalDetails()
    {
        int num = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{num}. {goal.GetDetailsString()}");
            num++;
        }
    }

    public void CreateGoal()
    {
        while (true)
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string name;
            string description;
            int points;
            int bonus;
            int target;

            if (int.TryParse(Console.ReadLine(), out int goalType))
            {
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                points = int.Parse(Console.ReadLine());

                if (goalType == 1)
                {
                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    _goals.Add(goal);
                }
                else if (goalType == 2)
                {
                    EternalGoal goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);
                }
                else if (goalType == 3)
                {
                    Console.Write("How many times does this goal need to be accomplished with this goal? ");
                    target = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    bonus = int.Parse(Console.ReadLine());
                    ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                    _goals.Add(goal);
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please input a number between 1-3.");
                    Thread.Sleep(2000);

                }
            }
            else
            {
                Console.WriteLine("Invalid Input. Please input a number between 1-3.");
                Thread.Sleep(2000);
            }
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine($"Congratulations! You have earned {_goals[index].RecordEvent()} points!");
        _score += _goals[index].RecordEvent();
    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}