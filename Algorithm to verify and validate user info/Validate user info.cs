using System;

namespace Algorithm_to_verify_and_validate_user_info
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            float salario;
            string estadocivil;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Digite seu Nome: ");
                nome = Console.ReadLine();
                Console.WriteLine();
            }
            while (nome == "");

            Console.WriteLine();
                

            do
            {
                Console.WriteLine("Digite sua Idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            while (idade <= 0 || idade > 150);

            Console.WriteLine();
                

            do
            {
                Console.WriteLine("Digite seu Salário ($): ");
                salario = float.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            while (salario == 0);

            Console.WriteLine();


            do
            {
                Console.WriteLine("Digite seu Estado Civil: s - Solteiro(a); c - Casado(a); v - Viuvo(a); d - Divorciado(a)");
                estadocivil = (Console.ReadLine());
                Console.WriteLine();
            }
            while (estadocivil != "s" && estadocivil != "c" && estadocivil != "v" && estadocivil != "d");

            Console.WriteLine();
               

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Confirme seus dados");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Salario: " + salario);
            Console.WriteLine("Estado Civil: " + estadocivil);
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Validação concluida");
        }
    }
}




                
                























