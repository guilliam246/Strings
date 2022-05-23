using System;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Guilliam";
            var lastName = "Oberhoslter";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My Name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);

            var text = "Hi John\nLook into the following paths\nC:\\folder\\folder2";
            Console.WriteLine(text);

        }
    }
}
