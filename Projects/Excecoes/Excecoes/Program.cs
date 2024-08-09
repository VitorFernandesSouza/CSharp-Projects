using Excecoes.Entities;
using System;
using Excecoes.Entities.Exceptions;

namespace Excecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com os dados da reserva: ");
                Console.Write("Numero do quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());
                Console.Write("Data de check-in (dd/MM/yyyy): ");
                DateTime chegada = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de check-out (dd/MM/yyyy): ");
                DateTime saida = DateTime.Parse(Console.ReadLine());

                Reserva reserva = new Reserva(numeroQuarto, chegada, saida);
                Console.Write("Reserva: " + reserva);
                Console.WriteLine();
                Console.WriteLine("Atualize sua reserva:");
                Console.Write("Data de check-in (dd/MM/yyyy): ");
                chegada = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de check-out (dd/MM/yyyy): ");
                saida = DateTime.Parse(Console.ReadLine());
                reserva.UpDateDatas(chegada, saida);
                Console.Write("Reserva: " + reserva);

            }
            catch (FormatException)
            {
                Console.WriteLine("Paizão vc errou o formato da data aí, dá um confere pra vc ver");
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro na reserva: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }

        }
    }
}