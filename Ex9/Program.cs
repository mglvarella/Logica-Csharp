using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Faça um programa que mostre todos os números pares entre os números digitados pelo usuário 
namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            int n2 = int.Parse(Console.ReadLine());
            int pares = 0;
            if(n1 > n2)
            {
                int troca = n2;
                n2 = n1;
                n1 = troca;
            }
            Console.Write("Os pares entre " + n1 + " e " + n2 + " são: ");
            while (n1 <= n2) { 
                if (n1 % 2 == 0){
                    Console.Write(n1 + " ");
                    pares++;
                }
                n1++;
            }
            Console.WriteLine("Existem " + pares + " pares no intervalo");
            Console.ReadKey();

        }
    }
}
