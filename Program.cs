using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exerxício_de_soma_simples
{
    class Program
    {
        static void Main(string[] args)
        {
           Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua à variável SOMA. 
           A seguir escrever o valor desta variável.
            
            int valor1, valor2, soma;
            


            Console.WriteLine("Digite o valor 1: ");
            valor1= int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 2: ");
            valor2 = int.Parse(Console.ReadLine());

                       
            soma = valor1 + valor2;

            Console.WriteLine("A soma dos valores é: " + soma);

            Console.ReadLine();



        }
    }
}
