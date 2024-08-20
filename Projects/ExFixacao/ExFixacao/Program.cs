using ExFixacao.Entities;

namespace ExFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cole aqui o caminho do arquivo: ");
            string arquivo = Console.ReadLine();

            List<Pessoa> pessoas = new List<Pessoa>();

            using (StreamReader sr = File.OpenText(arquivo))
            {
                while (!sr.EndOfStream)
                {
                    string[] campos = sr.ReadLine().Split(',');
                    string nome = campos[0];
                    string email = campos[1];
                    double salario = double.Parse(campos[2], System.Globalization.CultureInfo.InvariantCulture);
                    pessoas.Add(new Pessoa(nome, email, salario));
                }
            }
            Console.Write("Entre com a faixa salarial que deseja filtrar: ");
            double faixa = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Email das pessoa que tem a faixa salarial maior que " + faixa);

            var emailOrdem = pessoas.Where(p => p.Salario > faixa).OrderByDescending(p => p.Email).Select(p => p.Email);

            foreach (var m in emailOrdem)
            {
                Console.WriteLine(m);
            }

        }
    }
}
