using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string porcurarArquivo = @"C:\Users\vitor.fernandessouza\Documents\arquivo.txt";
            string porcurarArquivo2 = @"C:\Users\vitor.fernandessouza\Documents\arquivo2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(porcurarArquivo);
                fileInfo.CopyTo(porcurarArquivo2);
                string[] arquivoNoVetor = File.ReadAllLines(porcurarArquivo);
                
                foreach(string linha in arquivoNoVetor)
                {
                    Console.WriteLine(linha);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Deu erro pai, " + ex.Message); 
            }
        }
    }
}