using System;
using System.Linq;

class PredicateForNames
{

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Predicate<string> CheckLenght = (str) => str.Length <= n;
        Console.ReadLine().Split().Where(str => CheckLenght(str)).ToList().ForEach(n => Console.WriteLine(n));
    }
}
