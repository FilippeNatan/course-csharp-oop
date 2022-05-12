using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solução com POO
            Pessoa x, y;
            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.idade = int.Parse(Console.ReadLine());

            string pessoaMaisVelha;

            if (x.idade > y.idade)
            {
                pessoaMaisVelha = x.nome;
            }
            else if (y.idade > x.idade)
            {
                pessoaMaisVelha = y.nome;
            }
            else
            {
                pessoaMaisVelha = "As idades são iguais";
            }

            Console.WriteLine("Pessoa mais velha: {0}", pessoaMaisVelha);
        }
    }
}
