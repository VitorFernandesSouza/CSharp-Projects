using Contratos.Entities;
using Contratos.Entities.Enums;
using System;
using System.Globalization;

namespace Contratos // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do departamento: ");
            string depNome = Console.ReadLine();
            Console.WriteLine("Entre com os dados do colaborador");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Tipo de colaborador (Junior, Pleno, Senior): ");
            TipoColaborador level;
            string inputTipo = Console.ReadLine();

            while (!Enum.TryParse(inputTipo, true, out level) ||
                  (level != TipoColaborador.Pleno &&
                   level != TipoColaborador.Senior &&
                   level != TipoColaborador.Junior))
            {
                Console.WriteLine("Tipo inválido. Digite novamente.");
                Console.Write("Tipo de colaborador (Junior, Pleno, Senior): ");
                inputTipo = Console.ReadLine();
            }

            Console.Write("Salário base: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento departamento = new Departamento(depNome);
            Colaborador colaborador = new Colaborador(nome, level, salario, departamento);


            Console.Write("Quantos contratos gostaria de cadastrar? ");
            int qtd = int.Parse(Console.ReadLine());


            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine("Entre com o contrato #" + i);
                Console.Write("Entre com a data: dd/mm/aaaa ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Qual é o valor da hora? ");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração do contrato em horas: ");
                int horas = int.Parse(Console.ReadLine());

                ContratoHoras contratos = new ContratoHoras(data,valorHora, horas);
                colaborador.AddContrato(contratos);
            }

            Console.Write("Entre com o mês e ano para calcular os ganhos: ");
            string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));

            Console.WriteLine($"Nome: {colaborador.Nome}");
            Console.WriteLine($"Departamento: {colaborador.Departamento.Nome}");
            Console.WriteLine($"Valor ganho em {mesAno}: {colaborador.Ganhos(ano, mes).ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}