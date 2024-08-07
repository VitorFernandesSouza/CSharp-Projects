using Contratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos.Entities
{
    class Colaborador
    {
        public string Nome { get; set; }
        public TipoColaborador Cargo { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<ContratoHoras> Contratos { get; set; } = new List<ContratoHoras>(); // Assossiação * não se passa para construtor  

        public Colaborador() { }

        public Colaborador(string nome, TipoColaborador cargo, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Cargo = cargo;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddContrato(ContratoHoras contratos)
        {
            Contratos.Add(contratos); // Acessando minha lista de contratos e adicionando um contrato
        }
        public void RemoverContrato(ContratoHoras contratos)
        {
            Contratos.Remove(contratos);  // Acessando minha lista de contratos e removendo um contrato
        }
        public double Ganhos(int ano, int mes)
        {
            double soma = SalarioBase;

            foreach (ContratoHoras contrato in Contratos)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.ValorTotal();
                }
            }
            return soma;
        }

    }
}
