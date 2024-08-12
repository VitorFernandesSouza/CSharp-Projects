namespace Contribuintes.Colaborador
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }
        public List<Pessoa> Pessoas { get; set; }

        public Pessoa() { }
        public Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public virtual double Imposto()
        {
            return Imposto();
        }
    }
}
