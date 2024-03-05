using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroOperação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora, digite uma operação ( +, -, /, *): ");
            string simbolo = Console.ReadLine();

            if (simbolo == "+")
            {
                double resultado = (n1 + n2);
                Console.WriteLine("O resultado é: " + resultado);
            }
            else if (simbolo == "-")
            {
                double resultado = (n1 - n2);
                Console.WriteLine("O resultado é: " + resultado);
            }
            else if (simbolo == "*")
            {
                double resultado = (n1 * n2);
                Console.WriteLine("O resultado é: " + resultado);
            }
            else if (simbolo == "/")
            {
                double resultado = (n1 / n2);
                Console.WriteLine("O resultado é: " + resultado);
            }




        }
    }
}
