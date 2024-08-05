using System;

namespace Banco // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é o número da conta? ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Qual o nome do Titular da conta? ");
            string nome = Console.ReadLine();

            Conta conta = new Conta(n, nome, 0);

            Console.WriteLine("Deseja fazer um deposito inicial? s/n ");
            char resp = char.Parse(Console.ReadLine().ToLower());

            if (resp == 's')
            {
                Console.WriteLine("Qual o valor do deposito inicial? ");
                double dp = double.Parse(Console.ReadLine());
                conta.Deposito(dp);
            }

            Console.WriteLine("Dejesa sacar algum valor? s/n ");
            char resposta = char.Parse(Console.ReadLine().ToLower());

            if (resposta == 's')
            {
                Console.WriteLine($"Lembre - se que existe uma taxa fixa de {conta.Taxa} reais para saques");
                Console.WriteLine("Digite o valor que deseja sacar? ");
                double saque = double.Parse(Console.ReadLine());
                if (saque > conta.Saldo - conta.Taxa)
                {
                    Console.WriteLine("Saldo insuficiente!");
                }
                else
                {
                    conta.Saque(saque);
                    Console.WriteLine("Dados atualizados");
                }
            }
            Console.WriteLine(conta);



        }
    }
}