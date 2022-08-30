using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int pares = 0;
            while (n1 != 0)
            {
                Console.Write("Digite um número para verificar se ele é par ou digite 0 para sair: ");
                n1 = int.Parse(Console.ReadLine());
                if (n1 % 2 == 0)
                {
                    if(n1 != 0)
                    {
                        Console.WriteLine(n1 + " é par");
                        pares++;
                    }
                }
            }
            Console.WriteLine("Foram informados " + pares + " números pares");
            Console.ReadKey();
        }
    }
}
