using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solução com POO
            Pessoa x = new Pessoa();
            Pessoa y = new Pessoa();

            Funcionario n = new Funcionario();
            Funcionario s = new Funcionario();

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

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            n.nome = Console.ReadLine();
            Console.Write("Salário: ");
            n.salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            s.nome = Console.ReadLine();
            Console.Write("Salário: ");
            s.salario = float.Parse(Console.ReadLine());

            double mediaSalario = (n.salario + s.salario) / 2.0;

            Console.WriteLine("Salário médio {0} = ", mediaSalario);
        }
    }
}
