
using System;

class BinaryGapQuestion1
{
    static void BinaryGap()
    {
        int BinaryGap = 0;
        int BinaryGapLength = 0;
        int resposta = 0;
        
        // 1041 binario é 10000010001 
        //int[] Binary = { 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 ,1 };
        
        int N = 529;
        string BinaryForm = Convert.ToString(N, 2);
        char[] aux = BinaryForm.ToCharArray(0, BinaryForm.Length);
        
        int[] Binary = new int[aux.Length];  
        int i = 0;
        foreach (char c in aux)
        {
            Binary[i] = Convert.ToInt32(new string(c, 1));
            
            System.Console.Write(c);
            
            i++;
        }
        
        System.Console.WriteLine();
        
        foreach (int n in Binary)
        {
            System.Console.Write(n);
        }
        
        System.Console.WriteLine();
        System.Console.WriteLine();
        
        for( i = 0; i < Binary.Length; i++ )
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
                    if( BinaryGapLength > resposta )
                        resposta = BinaryGapLength;
                    
                    BinaryGap++;
                    
                    System.Console.WriteLine(BinaryGap + "a tamanho: "+ BinaryGapLength);
                    BinaryGapLength = 0;
                }
                
                count = 0;
            }
        }
        
        System.Console.WriteLine("\nMaior BinaryGap = "+ resposta);
        
        
        /*for(int i = 0; i < Binary.Length; i++)
        {
            if(Binary[i] == 1 && (i+1 < Binary.Length))
            {
                for(int j = i+1; Binary[j] != 1; j++)
                {
                    BinaryGapLength++;
                }
                if( BinaryGapLength > 0 )
                {
                    if( BinaryGapLength > resposta )
                        resposta = BinaryGapLength;
                    
                    BinaryGap++;
                    
                    System.Console.WriteLine(BinaryGap + "a tamanho: "+ BinaryGapLength);
                    BinaryGapLength = 0;
                }
            }
        }
        
        
        System.Console.WriteLine("\nMaior BinaryGap = "+ resposta);*/
    }
    
    static void Main() 
    {
        BinaryGap();
    }
}
