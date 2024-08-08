using Polimorfismo.Entities;
using System.Globalization;
using System;
using System.ComponentModel;

namespace Polimorfismo // Variáveis do mesmo tipo instânciadas com objetos diferentes, vão ter comportamentos diferntes.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> listaFuncionarios = new List<Funcionario>();

            Console.Write("Entre com a quantidade de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do {i}° funcionário");
                Console.Write("O funcionário é terceirizado? (s/n)  ");
                char c = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int h = int.Parse(Console.ReadLine());
                Console.Write("Valor das horas: ");
                double valorHoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (c == 's')
                {
                    Console.WriteLine();
                    Console.WriteLine("Qual o valor da dispesa adicional? ");
                    double adc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listaFuncionarios.Add(new FuncionarioTerceirizado(nome, h, valorHoras, adc)); // UPCASTING
                }
                else
                {
                    listaFuncionarios.Add(new Funcionario(nome, h, valorHoras));
                }
                Console.WriteLine();
                Console.WriteLine("PAGAMENTOS:");

                foreach (Funcionario obj in listaFuncionarios)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Nome: {obj.Nome}, R$ {obj.Pagamento().ToString("F2", CultureInfo.InvariantCulture)}");
                }

            }
        }
    }
}