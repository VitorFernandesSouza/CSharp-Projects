using System;
using System.Collections.Generic;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários vão ser registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Funcionário #" + (i + 1) + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());
                funcionarios.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("Entre com o ID do funcionário que receberá um aumento: ");
            int idAumento = int.Parse(Console.ReadLine());
            Console.Write("Digite a porcetagem do aumento que ele receberá: ");
            double porcentagem = double.Parse(Console.ReadLine());

            if (idAumento == null)
            {
                Console.WriteLine("Esse ID não existe!");
            }
            else
            {
                Console.WriteLine("Dados atualizados: ");
                funcionarios.Find(x => x.Id == idAumento).AumentarSalario(porcentagem);

            }
            Console.WriteLine();
            foreach (Funcionario obj in funcionarios)
                Console.WriteLine(obj);

        }
    }
}