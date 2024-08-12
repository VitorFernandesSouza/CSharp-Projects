namespace Contribuintes.Colaborador
{
    public class Fisica : Pessoa
    {
        public double GastosSaude { get; set; }

        public Fisica() { }

        public Fisica(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double Imposto()
        {
            double imposto = 0;

            if (RendaAnual < 20000.00)
            {
                imposto = RendaAnual * 0.15;
            }
            else
            {
                imposto = RendaAnual * 0.25;
            }
            if (GastosSaude > 0)
            {
                imposto -= GastosSaude * 0.5;
            }
            return imposto;

        }
    }
}
