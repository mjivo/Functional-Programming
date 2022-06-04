using System;
using System.Linq;

class FindEvensOrOdds
{
    static Func<int, string, bool> IsNumOddOrEven = (int num, string cmd) =>
    {
        if (cmd == "even")
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }
        else
        {
            if (num % 2 == 0)
            {
                return false;
            }
            return true;
        }
    };
    static void Main()
    {
        int[] bounnds = Console.ReadLine().Split().Select(str => int.Parse(str)).ToArray();
        int[] nums = CrateArrayWithBounds(bounnds[0], bounnds[1]);
        string cmd = Console.ReadLine();
        Console.WriteLine(string.Join(" ", nums.Where(n => IsNumOddOrEven(n, cmd))));

    }

    static int[] CrateArrayWithBounds(int startValue, int maxValue)
    {
        int lenght = maxValue - (startValue -1);
        int[] nums = new int[lenght];
        for (int i = 0; i < lenght; i++)
        {
            nums[i] = startValue + i;
        }
        return nums;
    }
}