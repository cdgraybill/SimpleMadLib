using System;

namespace MadLibExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string intro = "Lets do a MadLib!";
            TalkToUser(intro);

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("State a noun");
            string noun = Console.ReadLine();

            Console.WriteLine("State a place");
            string place = Console.ReadLine();

            GetName(name);
            GetNoun(noun);
            GetPlace(place);

            Console.WriteLine($"{name} decided to walk his {noun} to the {place}.");
            Console.ReadLine();
        }

        public static void TalkToUser(string text)
        {
            Console.WriteLine(text);
        }

        public static string GetName(string userInput)
        {
            string name = userInput;
            return name;
        }

        public static string GetNoun(string userInput)
        {
            string noun = userInput;
            return noun;
        }

        public static string GetPlace(string userInput)
        {
            string place = userInput;
            return place;
        }

    }
}
