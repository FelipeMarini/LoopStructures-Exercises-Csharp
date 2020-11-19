using System;

namespace LoopStructures_Exercises_Csharp  // System.Threading.Thread.Sleep(1000) é um delay para mostrar a saída
                                           // do resultado no console
{
                                           // Console.ForegroundColor = ConsoleColor.Green é cor da letra no console
    class Program
    {
        static void Main(string[] args)
        {

            int nota;

            do {

                Console.Write("Digite uma nota entre 0 e 10: ");
                nota = int.Parse(Console.ReadLine());

                if(nota < 0 || nota > 10) {
                
                Console.WriteLine();
                Console.WriteLine("Número Inválido"); 
                Console.WriteLine();
                
                }
                
            } while (nota < 0 || nota > 10);
                
                Console.WriteLine();
                Console.WriteLine("Número Aceito");

        }
    }
}



