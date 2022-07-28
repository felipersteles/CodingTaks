
class CodingTasks
{
    static void Resposta()
    {
        string[] ops = {"5","2","C","D","+"};
        //output = 30
        //string[] ops = {"5","-2","4","C","D","9","+","+"};
        //output = 27
        
        int aux, j = 0, nums = 0;
        
        // Descobrir quantos numeros tem o array
        foreach(string term in ops)
        {
            if(term=="C")
                nums--;
            else
                nums++;
        }
        
        int[] score = new int[nums];
        for(int i = 0; i < ops.Length; i++)
        {
            if(i+1<ops.Length)
            {
                if(ops[i+1] == "C")
                    i++;
            }
            if(ops[i] != "C")
            {
                if(int.TryParse(ops[i], out aux))
                {
                    score[j] = aux;
                    if(j<nums)
                        j++;
                }
                if(ops[i]=="D")
                {
                    score[j] = 2*score[j-1];
                    if(j<nums)
                        j++;
                }
                if(ops[i]=="+")
                {
                    score[j] = score[j-1] + score[j-2];
                    if(j<nums)
                        j++;
                }
            }
                
        }
        
       int sum = 0;
        foreach(int n in score)
        {
            sum += n;
        }
        System.Console.Write(sum);
    }
    
    static void Main() 
    {
        Resposta();
    }
}
