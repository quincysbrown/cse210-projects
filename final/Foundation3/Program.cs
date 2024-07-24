using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        Address lectureAddress = new Address("Salt Palace Convention Center", "90 S W Temple St", "Salt Lake City", "UT", 84101);
        LectureEvent commencement = new LectureEvent("Western Governors University Commencement", "Commencement ceremony for Western Governors University graduates in 2024", "8/17/2024", "12:00 PM MT", lectureAddress, "Elder Dieter F. Uchtdorf", 11000);
        events.Add(commencement);
        Address receptionAddress = new Address("The Madison Venue", "298 24th St #250", "Ogden", "UT", 84401);
        ReceptionEvent reception = new ReceptionEvent("Jed Hargrave Retirement Party", "Jed Hargrave will be retiring from his almost 30 years of work with Fresenius Medical Care. Please celebrate with him. Dinner will be provided.", "12/15/24", "5:30 PM MT", receptionAddress, "jen.hart@fmc.com");
        events.Add(reception);
        Address outdoorAddress = new Address("Golden Spike Event Center", "1181 Fairgrounds Dr", "Ogden", "UT", 84404);
        OutdoorEvent rodeo = new OutdoorEvent("2024 Rodeo", "Join us for a Pioneer Day Rodeo this summer for lots of family fun for everyone.", "7/24/24", "4 PM MT", outdoorAddress, "partly cloudy with a 25% chance of rain");
        events.Add(rodeo);
        commencement.GetStandardDetails();
        Console.WriteLine();
        commencement.GetFullDetails();
        Console.WriteLine();
        commencement.GetShortDetails();
        Console.WriteLine();
        reception.GetStandardDetails();
        Console.WriteLine();
        reception.GetFullDetails();
        Console.WriteLine();
        reception.GetShortDetails();
        Console.WriteLine();
        rodeo.GetStandardDetails();
        Console.WriteLine();
        rodeo.GetFullDetails();
        Console.WriteLine();
        rodeo.GetShortDetails();
    }
}