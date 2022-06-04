using System;
using System.Collections.Generic;
using System.Linq;

class ReverseAndExclude
{
    static Func<int[], int[]> ReverseArray = (int[] numbers) =>
    {
        int[] reversedNuners = new int[numbers.Length];
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            reversedNuners[(numbers.Length - 1) - i] = numbers[i];
        }
        return reversedNuners;
    };

    static Func<int, int, bool> IsDividable = (x, n) => !(x % n == 0);

    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(String.Join(" ",
            ReverseArray(numbers).Where(x => IsDividable(x, n)).ToArray()
            ));
    }
}