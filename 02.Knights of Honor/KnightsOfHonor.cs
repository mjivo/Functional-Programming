using System;
using System.Linq;

class KnightsOfHonor
{
    static void Main()
    {

        Console.ReadLine().Split().ToList().ForEach(n => Console.WriteLine(n.Insert(0, "Sir ")));

    }
}
