using Sobreposicao.Entities;
using System;
using System.Security.Cryptography;

namespace Sobreposicao // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Conta cc = new Conta(1001, "Alex", 500);
          Conta cc2 = new ContaPoupanca(1002, "Anna", 500, 0.01);

            cc.Saque(10);
            cc2.Saque(10);

            Console.WriteLine(cc.Saldo);
            Console.WriteLine(cc2.Saldo);
        }
    }
}