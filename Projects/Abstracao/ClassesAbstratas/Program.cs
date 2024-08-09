using System;
using ClassesAbstratas.Entities;

namespace Abstracao // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Conta> lista = new List<Conta>();

            lista.Add(new Poupanca(1001, "Alex", 500.0, 0.01));
            lista.Add(new ContaComercial(1002, "Maria", 500.0, 400));
            lista.Add(new Poupanca(1003, "Bob", 500.0, 0.01));
            lista.Add(new ContaComercial(1004, "Anna", 500.0, 500));

            double soma = 0;
            foreach (Conta obj in lista)
            {
                soma += obj.Saldo;
            }
            Console.WriteLine(soma);
            Console.WriteLine();

            
            foreach (Conta cc in lista)
            {
                cc.Saque(10.0);
                Console.WriteLine(cc.Saldo);
            }
            
        }
    }
}