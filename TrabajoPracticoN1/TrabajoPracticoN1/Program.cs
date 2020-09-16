using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace TrabajoPracticoN1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero binario");
            string binario = Console.ReadLine();
            Numero num = new Numero();
            string numero = num.BinarioDecimal(binario);
            Console.WriteLine(numero);

            Console.WriteLine("ingrese un numero decimal");
            string numero1 = Console.ReadLine();
            Numero num1 = new Numero();
            string num2 = num1.DecimalBinario(numero1);
            Console.WriteLine(num2);




            Console.ReadKey();
        }
    }
}
