using System;
using System.Globalization;

namespace Case // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto =   (preco > 20)  ?     desconto = preco * 0.1    :     desconto = preco * 0.05;
//                              (condição)    ?     valor se for verdadeiro   :     valor se for falso
            Console.WriteLine(desconto + preco);


        }
    }
}