using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A, int K) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        if(A!=null)
        {
            for(int i = 0; i < K ; i++)
            {
                int aux = A[A.Length-1];
                for(int j = 1; j < (A.Length); j++)
                {
                    A[A.Length - j] = A[(A.Length - j)-1];
                }
                A[0] = aux;
            }
        }
        
        return A;
    }
}
