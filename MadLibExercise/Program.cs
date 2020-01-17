using System;

namespace MadLibExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            Console.WriteLine($"{GetName()} decided to walk his {getNoun()} to the {getPlace()}.");
            Console.ReadLine();
        }

        public static void Intro()
        {
            Console.WriteLine("Let's do a MadLib");
            Console.ReadLine();
        }

        public static string GetName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }

        public static string getNoun()
        {
            Console.WriteLine("State a noun");
            string noun = Console.ReadLine();
            return noun;
        }

        public static string getPlace()
        {
            Console.WriteLine("State a place");
            string place = Console.ReadLine();
            return place;
        }

    }
}
