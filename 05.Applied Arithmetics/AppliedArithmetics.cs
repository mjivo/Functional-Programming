using System;
using System.Linq;

class AppliedArithmetics
{
    static void Main()
    {

        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        string cmd = Console.ReadLine();
        while (cmd != "end")
        {
            switch (cmd)
            {
                case "add":
                    Operation(n => n + 1);
                    break;
                case "multiply":
                    Operation(n => n * 2);
                    break;
                case "subtract":
                    Operation(n => n - 1);
                    break;
                case "print":
                    Operation(n =>
                    {
                        Console.Write(n + " ");
                        return n;
                    });
                    Console.WriteLine();
                    break;
            }
            cmd = Console.ReadLine();
        }

        void Operation(Func<int, int> func)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = func(numbers[i]);
            }
        }

    }
}