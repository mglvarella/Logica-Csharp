using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crie um programa o fatorial de um número informado pelo usuário 
namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para calcular seu fatorial: ");
            int num = int.Parse(Console.ReadLine());
            int cont = num - 1;
            int fatorial = 0;
            fatorial = num * cont;
            Console.Write(num + "!é " + num + "x" + cont);
            for (cont = cont -1; cont > 0; cont--)
            {
                Console.Write("x");
                Console.Write(cont);
                fatorial = fatorial * cont;
                num--;
            }
            Console.Write(" = " + fatorial);
            Console.ReadKey();
        }
    }
}
