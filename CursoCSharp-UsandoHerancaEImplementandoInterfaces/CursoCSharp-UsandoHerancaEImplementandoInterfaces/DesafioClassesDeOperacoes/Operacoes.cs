using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_UsandoHerancaEImplementandoInterfaces.DesafioClassesDeOperacoes
{
    public class Operacoes
    {
        public Soma Soma { get; set; }
        public Subtracao Subtracao { get; set; }
        public Multiplicacao Multiplicacao { get; set; }
        public Divisao Divisao { get; set; }
        public Operacoes()
        {
            this.Soma = new Soma();
            this.Subtracao = new Subtracao();
            this.Multiplicacao = new Multiplicacao();
            this.Divisao = new Divisao();
        }
    }
}
