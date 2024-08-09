using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excecoes.Entities.Exceptions;

namespace Excecoes.Entities
{
    class Reserva
    {
        public int NumeroQuarto { get; set; }
        public DateTime Chegada { get; set; }
        public DateTime Saida { get; set; }

        public Reserva() { }
        
        public Reserva(int numeroQuarto, DateTime chegada, DateTime saida)
        {
            if (saida <= chegada)
            {
                throw new DomainException("Vish camarada, a data de saída não pode ser anterior a data de chegada né");
            }
            if (chegada < DateTime.Now || saida < DateTime.Now)
            {
                throw new Exception("Tem coisa errada aí meu patrão, as datas não podem ser anteriores a data de hoje");
            }
            NumeroQuarto = numeroQuarto;
            Chegada = chegada;
            Saida = saida;
        }
        public int Duracao()
        {
            TimeSpan duracao = Saida.Subtract(Chegada);
            return (int)duracao.TotalDays;
        }

        public void UpDateDatas(DateTime chegada, DateTime saida)
        {
            if (chegada < DateTime.Now || saida < DateTime.Now)
            {
                throw new Exception("Tem coisa errada aí meu patrão, as datas não podem ser anteriores a data de hoje");
            }
            if (saida <= chegada)
            {
                throw new Exception("Vish camarada, a data de saída não pode ser anterior a data de chegada né");
            }
            Chegada = chegada;
            Saida = saida;
        }

        public override string ToString()
        {
            return "Quarto " + NumeroQuarto 
                             + ", check-in: " 
                             + Chegada.ToString("dd/MM/yyyy") 
                             + ", check-out: " 
                             + Saida.ToString("dd/MM/yyyy") 
                             + ", " + Duracao() + " noites";
        }
    }
}
