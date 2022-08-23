using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Efetuar o cálculo e a apresentação do valor de uma prestação em atraso, utilizando a fórmula: prestacao = valor + (valor*(taxa/100)*tempo).
namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor em atraso: ");
            float valor = float.Parse(Console.ReadLine());
            Console.Write("Insira o tempo de atraso(meses): ");
            int tempo = int.Parse(Console.ReadLine());
            Console.Write("Insira a taxa: ");
            float taxa = int.Parse(Console.ReadLine());
            float prestacao = valor + (valor * (taxa/100f) * tempo);
            Console.WriteLine("O valor da prestação é de R$" + prestacao);
            Console.ReadKey();



        }
    }
}
