internal class Program{
    private static void Main(string[] args){

        int n = 5;
        int[] vetor = new int [n];
        int[] vetor2 = new int[n];
        vetor[0] = 10;
        vetor[1] = 20;
        vetor[2] = 30;
        vetor[3] = 40;
        vetor[4] = 50;
                
        foreach (int i in vetor) { 
            Console.WriteLine(i + ". ");
        }

        for (int i = 0; i < n; i++)
        {          
            Console.Write(vetor[n - i - 1] + ". ");
        }
    }
}