using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Fzer um algorítmo para ler dois valores reais, fazer o cálculo e imprimir na tela:
 (A) soma desses valores; (B) o produto deles; (C) o quociente entre eles */
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora, escolha uma opção: \n (A) Somas; \n (B) Multiplicação \n (C) Divisão");
            string op = Console.ReadLine(); 
            Console.Write("Digite um número: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            float n2 = float.Parse(Console.ReadLine());
            op = op.ToUpper();
            Console.WriteLine(op);
            Console.ReadKey();
            switch (op)
            {
                case "A":
                    Console.Write(n1 + "+" + n2 + "=" + n1 + n2);
                    Console.ReadKey();
                    break;
                case "B":
                    Console.Write(n1 + "x" + n2 + "=" + n1 * n2);
                    Console.ReadKey();
                    break;
                case "C":
                    Console.Write(n1 + "/" + n2 + "=" + n1 / n2);
                    Console.ReadKey();
                    break;
            }
        }
    }
}
