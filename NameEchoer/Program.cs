using NameEchoer;
using System;

namespace Names
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Echoer echoer = new();

            List<string> list = new List<string>();
            list.Add("Program 1: Greets user by the provided name.");
            list.Add("Program 2: Only greets users whose name is either Bob or Alice");
            list.ForEach(Console.WriteLine);

            Console.WriteLine("Enter a program number");
            string program = Console.ReadLine() ?? string.Empty;

            switch (program)
            {
                case "1":
                    string echoedName = echoer.EchoName();
                    Console.WriteLine(echoedName);
                    break;

                case "2":
                    string echoedAB = echoer.EchoNameAB();
                    Console.WriteLine(echoedAB);
                    break;

                default:
                    Console.WriteLine("Not a prorgram");
                    break;
            }
        }
    }
}