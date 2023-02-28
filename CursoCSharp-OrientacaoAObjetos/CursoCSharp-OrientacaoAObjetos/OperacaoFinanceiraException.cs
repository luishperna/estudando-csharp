using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_OrientacaoAObjetos
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException(string messagem) : base(messagem)
        {

        }

        // InnerException (Exceção Interna) => Exceção que deriva de outra exceção
        public OperacaoFinanceiraException(string messagem, Exception excecaoInterna) : base(messagem, excecaoInterna) 
        {

        }
    }
}
