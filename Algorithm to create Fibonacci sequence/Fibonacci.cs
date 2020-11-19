using System;

namespace Algorithm_to_create_Fibonacci_sequence_until_500
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0;
            int num2 = 1;
            int num3;
            int i;
            int limit;
            

            Console.Write("Digite o número que será o limite da série de Fibonacci: ");
            limit = int.Parse(Console.ReadLine());

            Console.Write(num1 + " " + num2 + " ");

            for (i=2; i < limit; i++) {

                num3 = num1 + num2;

                Console.Write(num3 + " ");

                num1 = num2;

                num2 = num3;  }
        }
    }
}



            

            

