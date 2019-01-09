using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        Dictionary<int, int> freqCounts = new Dictionary<int, int>();
        foreach(var item in A)
        {
            var currentValue = 0;
            freqCounts.TryGetValue(item, out currentValue);
            freqCounts[item] = currentValue + 1;
        }
        foreach(var keyPair in freqCounts)
        {
            if(keyPair.Value % 2 != 0)
            {
                return keyPair.Key;
            }
        }
        return 0;
    }
}