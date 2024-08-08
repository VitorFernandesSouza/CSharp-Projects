using Casting.Entities;
using System;

namespace Casting // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta cc = new Conta(1001, "Vitor", 0.0);
            ContaEmpresarial ce = new ContaEmpresarial(1002, "Maria", 0.0, 500.00);


            // UPCASTING = Conversão da subclasse para a superclasse
            // ContaEmpresárial é uma Conta

            Conta cc1 = ce; // Conta recebe qualquer obj do tipo Conta = UPCASTING
            Conta cc2 = new ContaPoupanca(2003, "Vitor", 0.0, 1200.00);
            Conta cc3 = new ContaEmpresarial(1002, "Vitor", 0.0, 15000.00);


            // DOWNCASTING = Precisa de conversão da subClasse para a classe
            
            // ContaEmpresarial cc4 = cc3;

            ContaEmpresarial cc5 = (ContaEmpresarial)cc3; // Conversão 

            if (cc3 is ContaPoupanca)
                Console.WriteLine("Poupança!");

            if (cc5 is ContaEmpresarial)
                Console.WriteLine("Empresarial!");

        }
    }
}