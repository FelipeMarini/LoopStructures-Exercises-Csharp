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
            
            do{
                Console.WriteLine();
                Console.WriteLine("Digite seu Nome: ");
                nome = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite sua Idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Digite seu Salário ($): ");
                salario = float.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Digite seu Estado Civil: s - Solteiro(a); c - Casado(a); v - Viuvo(a); d - Divorciado(a)");
                estadocivil = (Console.ReadLine());
                Console.WriteLine();

                if(nome == "") {Console.WriteLine("------------------------"); Console.WriteLine("Defina um nome válido"); 
                                nome = "null";}

                if(idade < 0 || idade >150) {Console.WriteLine("------------------------"); Console.WriteLine("Defina uma idade válida"); 
                                             idade = 1;}

                if(salario == 0) {Console.WriteLine("------------------------"); Console.WriteLine("Defina um salário válido"); 
                                  salario = 0;}

                if(estadocivil == "s" || estadocivil == "c" || estadocivil == "v" || estadocivil == "d"){}
                
                else{
                    Console.WriteLine("-------------------------------"); Console.WriteLine("Defina um estado civil válido");
                    estadocivil = "null";
                    }
            
            } while(nome == "null" || idade == 1 || salario == 0 || estadocivil == "null" );

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
