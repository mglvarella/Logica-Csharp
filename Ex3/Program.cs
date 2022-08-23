using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Algorítimo que receba 3 valores e que retorne o quadrado da soma deles
namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor: ");
            int v2 = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor: ");
            int v3 = int.Parse(Console.ReadLine());
            int soma = v1 + v2 + v3;
            double result = Math.Pow(soma, 2);
            Console.WriteLine("O quadrado da soma dos valores é " + result);
            Console.ReadKey();
        }
    }
}
