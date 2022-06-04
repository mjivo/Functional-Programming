using System;
using System.Linq;

class ActionPoint
{
    static Action<string[]> PrintNames = (names) =>
    {
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    };

    static void Main()
    {
        string[] names = Console.ReadLine().Split();

        PrintNames(names);
    }
}
