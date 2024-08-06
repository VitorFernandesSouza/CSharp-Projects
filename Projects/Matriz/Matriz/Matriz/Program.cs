using System;
using System.Security.Cryptography;

namespace Matriz // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a qtd de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine());
            Console.Write("Digite a qtd de colunas da matriz: ");
            int colunas = int.Parse(Console.ReadLine());

            int[,] mat = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.Write("Digite um número para procurar na matriz: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Posição " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Acima: " + mat[i - 1, j]);
                        }
                        if (j < colunas - 1)
                        {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }
                        if (i < linhas - 1)
                        {
                            Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}