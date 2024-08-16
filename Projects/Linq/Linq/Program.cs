namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vetor de inteiros
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Consulta LINQ para filtrar os números pares e multiplicar por 10
            var resultado = numeros.Where(x => x % 2 == 0).Select(x => x * 10);

            // Foreach para exibir o resultado
            foreach (var item in resultado)
            {
                Console.WriteLine(item);                    
            }

        }
    }
}
