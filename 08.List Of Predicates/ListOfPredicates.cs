using System;
using System.Linq;

class ListOfPredicates
{
    static Func<int, int[]> ArrayFiller = (int n) =>
    {
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = i + 1;//values have to start from 1 and go to value = n
        }
        return arr;
    };
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Predicate<int> IsDividebaleByDividers = (int num) =>
        {
            foreach (int devider in dividers)
            {
                if (num % devider != 0)
                    return false;
            }
            return true;
        };

        Console.WriteLine(string.Join(" ", 
            ArrayFiller(n).Where(x => IsDividebaleByDividers(x))
            ));
    }
}

