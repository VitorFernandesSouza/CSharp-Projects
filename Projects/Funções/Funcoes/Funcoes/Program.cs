using System;

namespace Funcoes // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 80));
            string frase = "   - abcde FGHIJ ABC abc DEFG -    ";
            Console.WriteLine("Original: " + frase);
            Console.WriteLine();
            Console.WriteLine(new string('-', 80));

            var upper = frase.ToUpper();
            Console.WriteLine("Maiusculo: " + upper);
            Console.WriteLine();
            Console.WriteLine(new string('-', 80));

            var lower = frase.ToLower();
            Console.WriteLine("Minusculo: " + lower);
            Console.WriteLine();
            Console.WriteLine(new string('-', 80));

            var trim = frase.Trim();
            Console.WriteLine("Sem espaçoes em branco no inicio e no fim: " + trim);
            Console.WriteLine();
            Console.WriteLine(new string('-', 80));

            var indexOf = frase.IndexOf("bc");
            Console.WriteLine("Index da primeira vez que 'bc' aparece na frase: " + indexOf);
            Console.WriteLine();
            Console.WriteLine(new string('-', 80));

            var lastindexOf = frase.LastIndexOf("bc");
            Console.WriteLine("Index da última vez que 'bc' aparece na frase: " + lastindexOf);
            Console.WriteLine();
            Console.WriteLine(new string('-', 80));

            var subString = frase.Substring(3);
            Console.WriteLine("Cortando string apartir do index 3: " + subString);
            Console.WriteLine();
            Console.WriteLine(new string('-', 80));

            var subString2 = frase.Substring(3,5);
            Console.WriteLine("Cortando 5 caracteres apartir do index 3: " + subString2);
            Console.WriteLine();
            Console.WriteLine(new string('-', 80));

            var replace = frase.Replace('a', 'x');
            Console.WriteLine("Trocar todo caracter 'a' pelo 'x': " + replace);
            Console.WriteLine();
            Console.WriteLine(new string('-', 80));

            bool vazio = String.IsNullOrEmpty(frase);
            Console.WriteLine("Se a string é nula ou vazia: " + vazio);
            Console.WriteLine();
            Console.WriteLine(new string('-', 80));

            bool branco = String.IsNullOrWhiteSpace(frase);
            Console.WriteLine("Se a string é nula ou está com espaços em branco: " + branco);
            Console.WriteLine();
            Console.WriteLine(new string('-', 80));




        }
    }
}