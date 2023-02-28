using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_OrientacaoAObjetos
{
    // Criando uma classe para exceção herdando de Exception
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public SaldoInsuficienteException(string messagem) : base(messagem)
        {

        }
    }
}
