using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Insira o valor do kilo: ");
            decimal valorKilo = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Insira a tara do prato: ");
            decimal taraPrato = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Insira o peso do prato: ");
            decimal pesoPrato = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine();
            decimal preco = (pesoPrato - taraPrato) * valorKilo;
            
            Console.WriteLine($"O prato de {taraPrato} gramas custa: R$ {preco.ToString("C")}");
            Console.WriteLine("Pressione qualquer tecla para sair");
        }
    }
}
