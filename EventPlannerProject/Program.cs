using System;

namespace EventPlannerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var location = "70 Ranger Lane, Hayden, AL 35079";
            var eventTime = "6:00PM-11:00PM";

            Console.WriteLine("Welcome to the Event Planner!");
            Console.WriteLine();

            Console.WriteLine("How many people will be attending you event?");
            var attending = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("What kind of food will you be bringing?");
            var food = Console.ReadLine();
            var foodNeeded = FoodNeeded(attending);

            Console.WriteLine("What will you be bringing to drink on?");
            var drink = Console.ReadLine();         

            Console.WriteLine();

            Console.WriteLine("What kind of event are you planning?");
            Console.WriteLine("1. Casual\n2. Elegant\n3. Costume");
            var eventType = Console.ReadLine();

            if (eventType == "1")
            {
                eventType = "Casual";
            }
            else if (eventType == "2")
            {
                eventType = "Elegant";
            }
            else if (eventType == "3")
            {
                eventType = "Costume";
            }

            Console.WriteLine("Will it be adult only or kid friendly?");
            Console.WriteLine("1. Adults only\n2. Kid Friendly");
            var ageRestriction = Console.ReadLine();

            if (ageRestriction == "1")
            {
                ageRestriction = "Adult Only";
            }
            else if (ageRestriction == "2")
            {
                ageRestriction = "Kid Friendly";
            }

            Console.Clear();
            Console.WriteLine($"This event will have {attending} people attending.\n" +
                $"We will need {foodNeeded} plates of {food} and {drink} to drink.\n" +
                $"It will be held at {location} from {eventTime}!\n" +
                $"This will be a {eventType} event!\n" +
                $"This will be a/an {ageRestriction} event!");
        }

        public static int FoodNeeded(int attending)
        {
            var foodNeeded = attending * 2;
            return foodNeeded;
        }
    }
}
