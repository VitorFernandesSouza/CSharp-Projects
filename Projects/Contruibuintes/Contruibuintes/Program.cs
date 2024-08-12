using Contribuintes.Colaborador;
using Contribuintes.Colaborador.Enums;
using System.Net.WebSockets;

namespace Contribuintes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            Console.WriteLine("Entre com o número de taxas a pagar: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Taxa da {i}° pessoa");
                Console.Write("Pessoa Física ou Jurídica (fisica/juridica)? ");
                string tipoPessoa = Console.ReadLine();
                TipoPessoa tipo = (TipoPessoa)Enum.Parse(typeof(TipoPessoa), tipoPessoa.ToLower());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine());

                if (tipo == TipoPessoa.fisica)
                {
                    Console.Write("Gastos com saúde: ");
                    double gastosSaude = double.Parse(Console.ReadLine());

                    Pessoa pessoa = new Fisica(nome, rendaAnual, gastosSaude);
                    pessoas.Add(pessoa);
                }
                else 
                {
                    Console.Write("Número de funcionários: ");
                    int numeroFuncionarios = int.Parse(Console.ReadLine());

                    Pessoa pessoa = new Juridica(nome, rendaAnual, numeroFuncionarios);
                    pessoas.Add(pessoa);
                }
            }
            Console.WriteLine("\nImpostos a pagar:");
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine($"{pessoa.Nome}: $ {pessoa.Imposto().ToString("F2")}");
                
            }
                Console.WriteLine("Total de impostos: $" + pessoas.Sum(pessoas => pessoas.Imposto()).ToString("F2"));
        }
    }
}
