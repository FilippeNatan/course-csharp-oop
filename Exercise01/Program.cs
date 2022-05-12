using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solução sem POO

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            string nomePessoa1 = Console.ReadLine();
            Console.Write("Idade: ");
            int idadePessoa1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            string nomePessoa2 = Console.ReadLine();
            Console.Write("Idade: ");
            int idadePessoa2 = int.Parse(Console.ReadLine());

            string pessoaMaisVelha;

            if (idadePessoa1 > idadePessoa2)
            {
                pessoaMaisVelha = nomePessoa1;
            }
            else if (idadePessoa2 > idadePessoa1)
            {
                pessoaMaisVelha = nomePessoa2;
            }
            else
            {
                pessoaMaisVelha = "As idades são iguais";
            }

            Console.WriteLine("Pessoa mais velha: {0}", pessoaMaisVelha);
        }
    }
}
