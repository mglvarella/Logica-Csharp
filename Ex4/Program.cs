using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Calcular preço de venda de um terreno retangular, 
sendo dadas as medidas de frente e de um dos lados do
terreno (em metros) e o preço do metro quadrado*/
namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da frente do terreno: ");
            float frente = float.Parse(Console.ReadLine());
            Console.Write("Digite o tamanho da lateral do terreno: ");
            float lat = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor do metro quadrado: ");
            float metro2 = float.Parse(Console.ReadLine());
            float preco = ((frente * lat) * metro2);
            Console.WriteLine("O preço do terreno é de R$" + preco);
            Console.ReadKey();
        }
    }
}
