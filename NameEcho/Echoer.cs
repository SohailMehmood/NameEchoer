using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameEchoer
{
    public class Echoer
    {
        public string EchoName()
        {
            Console.WriteLine("Please enter your name");

            string name = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrEmpty(name))
            {
                name = "User";
            }

            return $"Hello {name}";
        }

        public string EchoNameAB()
        {
            Console.WriteLine("Please enter your name");

            string name = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrEmpty(name))
            {
                name = "User";
            }

            else if (name.ToLower() == "alice" || name.ToLower() == "bob")
            {
                return $"Hello {name}";
            }

            else
            {
                name = "User";
            }

            return $"Hello {name}";
        }
    }
}
