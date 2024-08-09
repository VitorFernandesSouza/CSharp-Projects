using ExercicioExceptions.Entities;
using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Globalization;
using ExercicioExceptions.Entities.Exceptions;

namespace ExercicioExceptions // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bem Vindo ao Banco!");
                Console.WriteLine("Digite os dados da conta:");
                Console.Write("Numero: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Titular: ");
                string titular = Console.ReadLine();
                Console.Write("Saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                Console.Write("Limite de saque: ");
                double limiteEmprestimo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Conta conta = new Conta(numero, titular, saldo, limiteEmprestimo);

                Console.WriteLine();
                Console.Write("Digite um valor para depósito:");
                double quantiaDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Deposito(quantiaDeposito);

                Console.Write("Digite o valor do saque: ");
                double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Saque(quantia);


                Console.WriteLine("Novo saldo: " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro de formato: " + e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro na conta: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
        }
    }
}