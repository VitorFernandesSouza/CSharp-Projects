namespace BlocoUsing
{
    public class Program
    {
        static void Main(string[] args)
        {
            string arquivo = @"C:\Users\...\Documents\arquivo.txt";
            string arquivoDestino = @"C:\Users\...\Documents\arquivoDestino.txt";
            try
            {
                using (StreamReader sr = File.OpenText(arquivo))
                {
                    while (!sr.EndOfStream)
                    {
                        string linha = sr.ReadLine();
                        Console.WriteLine(linha);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ih rapaz, deu um erro aí");
                Console.WriteLine(e.Message);
            }

            try // Abre o arquivo para adicionar mais texto, mantendo o que já estava lá, e escreve cada linha em maiúsculas.

            {
                string[] linhas = File.ReadAllLines(arquivo); // Lê todas as linhas do arquivo

                using (StreamWriter sw = File.AppendText(arquivoDestino))
                {
                    foreach (string linha in linhas)
                    {
                        sw.WriteLine(linha.ToUpper());
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Ih rapaz, deu um erro aí");
                Console.WriteLine(e.Message);
            }
        }
    }
}
