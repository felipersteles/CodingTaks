using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        int BinaryGapLength = 0;
        int answer = 0;

        string BinaryForm = Convert.ToString(N, 2);
        char[] aux = BinaryForm.ToCharArray(0, BinaryForm.Length);

        int[] Binary = new int[aux.Length];

        int i = 0;
        foreach(char c in aux)
        {
            Binary[i] = Convert.ToInt32(new string(c, 1));
            i++;
        }

        for(i = 0; i < Binary.Length; i++)
        {
            if(Binary[i] == 1 && (i+1 < Binary.Length))
            {
                int count = 0;

                for(int j = i+1; j < Binary.Length ; j++)
                {
                    count++;
                    if(Binary[j] == 1)
                    {
                        BinaryGapLength = count - 1;
                        break;
                    }
                }
                
                if( BinaryGapLength > 0 )
                {
                    if( BinaryGapLength > answer )
                        answer = BinaryGapLength;

                    BinaryGapLength = 0;
                }
                
                count = 0;
            }
        }

        return answer;
    }
}
