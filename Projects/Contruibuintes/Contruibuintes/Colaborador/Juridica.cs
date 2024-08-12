namespace Contribuintes.Colaborador
{
    public class Juridica : Pessoa
    {
        public int NumeroFuncionarios { get; set; }

        public Juridica() { }

        public Juridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double Imposto()
        {
            double imposto = 0;

            if (NumeroFuncionarios > 10)
            {
                imposto = RendaAnual * 0.14;
            }
            else
            {
                imposto = RendaAnual * 0.16;
            }
            return imposto;
        }

    }
}

