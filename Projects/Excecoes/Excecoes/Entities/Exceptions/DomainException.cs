using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string mensagem) : base(mensagem)
        {
        }
        
    }

}
