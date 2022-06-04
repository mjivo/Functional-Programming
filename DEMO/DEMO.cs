using System;
using System.Linq;

class DEMO
{
    static void Main()
    {

        Func<string, string> WordPlusLenghtFunc = (string msg) =>
        {
            return msg += $@" - {msg.Length}";
        };
        Console.WriteLine(WordPlusLenghtFunc("Func"));

        Action<string> WordPlusLenghtAction = (string msg) =>
        {
            Console.WriteLine(msg += $@" - {msg.Length}");
        };
        WordPlusLenghtAction("Action");

        Predicate<int> IsNegative = x => x < 0;

        bool isNegative = false;
        if (isNegative = IsNegative(int.Parse(Console.ReadLine())))
        {
            Console.WriteLine(isNegative);
        }

        Console.ReadLine().Split().Select(x => int.Parse(x)).Where(n => IsNegative(n)).OrderBy(n => n).ToList().ForEach(x => Console.WriteLine(x));
        Console.ReadLine().Split().Select(x => int.Parse(x)).ToList().FindAll(IsNegative).ForEach(x => Console.WriteLine(x));



    }
}
