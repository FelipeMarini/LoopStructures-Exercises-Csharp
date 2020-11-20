using System;

namespace Algorithm_to_create_Fibonacci_sequence_until_500
{
    class Program
    {                                           // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 .....   (Fibonacci) 
        static void Main(string[] args)
        {
           int anterior = 0, atual = 1, soma;

           Console.WriteLine();

           Console.Write("0 1 ");

           
        do {
            soma = anterior + atual;

            anterior = atual;

            atual = soma; 
            
            Console.Write($"{soma} " );
            
            }
                  
            while (atual < 500);      // valor limite da sequência que pode ser definido

            Console.WriteLine("   FIM");
            
        }
    }
}



           





            

            

