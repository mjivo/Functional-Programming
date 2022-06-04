using System;
using System.Linq;

class CustomMinFunction
{
    static Func<int[], int> MinFunc = (int[] nums) =>
    {
        int minNum = int.MaxValue;
        foreach (int num in nums)
        {
            if (num < minNum)
            {
                minNum = num;
            }
        }
        return minNum;
    };


    static void Main()
    {
        Console.WriteLine(MinFunc(Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray()));
    }
}
