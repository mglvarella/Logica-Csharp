using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Faça um programa que apresente a soma dos números de 0 a 1000
namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont;
            int soma = 0;
            for (cont = 0; cont <= 1000; cont++){
                Console.Write(soma + "+" + cont);
                soma += cont;
                Console.WriteLine("=" + soma);
            }
            Console.WriteLine(soma);
            Console.ReadKey();
        }
    }
}
