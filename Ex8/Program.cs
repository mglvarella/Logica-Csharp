using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crie um programa que receba, calcule e mostre o quadrado de um valor informado pelo usuario e saia quando digitar 0
namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num != 0)
            {
                Console.WriteLine("Digite um número para calcular seu quadrado");
                Console.WriteLine("Digite 0 para encerrar");
                Console.Write("Número: ");
                num = int.Parse(Console.ReadLine());
                double quadrado = Math.Pow(num, 2);
                Console.WriteLine("O quadrado de " + num + " é " + quadrado + "\n");

            }   
        }
    }
}
