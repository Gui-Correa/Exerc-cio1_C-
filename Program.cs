using System;

namespace Exercicios_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, cidade;
            int idade;
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua cidade");
            cidade = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Seu nome é:" + nome);
            Console.WriteLine("Sua cidade é:" + cidade);
            Console.WriteLine("Sua idade é:" + idade);

            Console.ReadKey();

        }
    }
}



