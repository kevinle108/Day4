using System;
using System.Collections.Generic;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Anna", "Barry", "Charlie", "David", "Eddie", "Frank" };
            names.Add("Gail"); // Add "Gail" to the end of the list
            names.Add("Harry"); // Add "Harry" to the end of the list
            names[0] = "Andy"; // change the first item to "Andy"
            names.RemoveAt(2); // removes the third item
            names.Insert(4, "Paul"); // add "Paul" as the fifth item
            names.RemoveAt(names.Count - 1); // removes the last item
            Console.WriteLine($"the index of Paul is {names.IndexOf("Paul")}"); // finds the index of Paul
            Console.WriteLine($"'names' is a list of strings with {names.Count} items");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
