using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Entities
{
     class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        
        public Cliente(string nome, string email, DateTime dataNascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }

        public Cliente()
        {
        }

        public override string ToString()
        {
          return $"Cliente: {Nome}, Email: {Email}, Data de Nascimento: {DataNascimento.ToString("dd/MM/yyyy")}.";
        }
    }
}
