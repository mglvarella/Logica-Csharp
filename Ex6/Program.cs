using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crie um algorítmo para receber o salário de um funcionário, o percentual de aumento e o salário final
namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salário atual: ");
            float salario = float.Parse(Console.ReadLine());
            Console.Write("Digite o percentual de aumento: ");
            float percentual = float.Parse(Console.ReadLine());
            float salarioNovo = salario + (salario * (percentual / 100f));
            Console.Write("O novo salário será de R$" + salarioNovo);
            Console.ReadKey();
        }
    }
}
