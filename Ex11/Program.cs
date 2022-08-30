using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crie um programa que calcule e mostre a tabuada do número informado pelo usuário
namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para obter sua tabuada: ");
            int num = int.Parse(Console.ReadLine());
            int cont = 0;
            Console.WriteLine("A tabuada do " + num + " é:");
            for (cont = 0; cont <= 30; cont++)
            {
                int tabuada = cont * num;
                Console.WriteLine(num + " x " + cont + " = " + tabuada);
            }
            Console.ReadKey();
        }
    }
}
