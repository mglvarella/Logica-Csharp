using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Pergunte 10 idades e faça a média entre eles
namespace Exercícios
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            int cont;
            float media;
            int soma = 0;
            for (cont = 1; cont <= 10; cont++)
            {
                Console.Write("Digite a idade do aluno " + cont + ":");
                idade = int.Parse(Console.ReadLine());
                soma += idade;
            }
            media = soma/10f;
            Console.WriteLine("A média das idades é " + media);
            Console.ReadKey();
        }
    }
}
