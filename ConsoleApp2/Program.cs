using NameEchoer;
using System;

namespace Names
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Echoer echoer = new Echoer();
            EchoerAB echoerAB = new EchoerAB();

            Console.WriteLine("Enter a program number");
            string program = Console.ReadLine() ?? string.Empty;

            switch (program)
            {
                case "1":
                    string echoedName = echoer.EchoName();
                    Console.WriteLine(echoedName);
                    break;

                case "2":
                    string echoedAB = echoerAB.EchoNameAB();
                    Console.WriteLine(echoedAB);
                    break;

                default:
                    Console.WriteLine("Not a prorgram");
                    break;
            }
        }
    }
}