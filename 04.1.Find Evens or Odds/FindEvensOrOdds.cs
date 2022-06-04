using System;
using System.Linq;

class FindEvensOrOdds
{
    static Predicate<int> IsNumEven = (int num) =>
    {
        return num % 2 == 0;
    };
    static Predicate<int> IsNumOdd = (int num) =>
    {
        return num % 2 != 0;
    };
    static void Main()
    {
        int[] bounnds = Console.ReadLine().Split().Select(str => int.Parse(str)).ToArray();
        int[] nums = CrateArrayWithBounds(bounnds[0], bounnds[1]);
        
        if (Console.ReadLine() == "even")
        {
            Console.WriteLine(string.Join(" ", nums.Where(n => IsNumEven(n))));
        }
        else
        {
            Console.WriteLine(string.Join(" ", nums.Where(n => IsNumOdd(n))));
        }
    }

    static int[] CrateArrayWithBounds(int startValue, int maxValue)
    {
        int lenght = maxValue - (startValue - 1);
        int[] nums = new int[lenght];
        for (int i = 0; i < lenght; i++)
        {
            nums[i] = startValue + i;
        }
        return nums;
    }
}
