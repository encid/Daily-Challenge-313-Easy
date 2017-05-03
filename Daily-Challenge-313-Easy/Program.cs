using System;
using System.Collections.Generic;

namespace DailyChallenge313Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckSubsetSum(new List<int> { 1, 2, 3 }));
            Console.WriteLine(CheckSubsetSum(new List<int> { -5, -3, -1, 2, 4, 6 }));
            Console.WriteLine(CheckSubsetSum(new List<int> { }));
            Console.WriteLine(CheckSubsetSum(new List<int> { -1, 1 }));
            Console.WriteLine(CheckSubsetSum(new List<int> { -97364, -71561, -69336, 19675, 71561, 97863 }));
            Console.WriteLine(CheckSubsetSum(new List<int> { -53974, -39140, -36561, -23935, -15680, 0 }));

            Console.ReadLine();
        }

        static bool CheckSubsetSum(List<int> input)
        {
            if (input.Count == 0) return false;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == 0) return true;
                if (input.Contains(input[i] * -1)) return true;                
            }

            return false;
        }
    }
}
