using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioExceptions.Entities.Exceptions;

namespace ExercicioExceptions.Entities
{
     class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Conta() { }
        public Conta(int numero, string titular, double saldo, double limiteSaque)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double quantia)
        {
             Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            if (quantia > LimiteSaque)
            {
                throw new DomainException("Erro no saque: A quantia excede o limite de saque, paizão");
            }
            if (quantia > Saldo)
            {
                throw new DomainException("Erro no saque: Saldo insuficiente, aí não da né paizão");
            }
            Saldo -= quantia + 5.0;
        }


    }
}
