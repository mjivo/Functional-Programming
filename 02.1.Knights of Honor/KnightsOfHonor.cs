using System;
using System.Linq;

class KnightsOfHonor
{
    static Action<string> AddSirAndPrint = (s) =>
    {
        s = s.Insert(0, "Sir ");
        Console.WriteLine(s);
    };

    static void Main()
    {

        Console.ReadLine().Split().ToList().ForEach(n => AddSirAndPrint(n));

    }
}
