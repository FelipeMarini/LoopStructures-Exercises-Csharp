using System;

namespace Algorithm_to_verify_username_different_from_password
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            string senha = "";

            while(true) {
                
                Console.WriteLine("Digite seu nome de usuário:");
                nome = Console.ReadLine();

                Console.WriteLine("Digite seu senha:");
                senha = Console.ReadLine();

                if(nome == senha){
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Erro. A senha deve ser diferente do nome de usuário, digite uma senha válida.");
                } else {break;}
            }
            
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Validação feita com sucesso, seja bem vindo " + nome);
            Console.WriteLine("--------------------------------------------");

        }
    }
}
