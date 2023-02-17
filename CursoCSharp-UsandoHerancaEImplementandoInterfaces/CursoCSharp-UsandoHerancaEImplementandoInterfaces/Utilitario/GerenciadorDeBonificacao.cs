using CursoCSharp_UsandoHerancaEImplementandoInterfaces.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_UsandoHerancaEImplementandoInterfaces.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacao { get; private set; }
        
        // Diretor está herdando de funcionario, logo se aplica a este método
        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacao += funcionario.GetBonificacao();
        }

        // Sobrecarga de método => O mesmo método receber outro tipo de parâmetro (argumento)
        // Polimorfismo => Método trabalha de maneira diferente de acordo com o parâmetro recebido
        //public void Registrar(Diretor diretor)
        //{
        //    this.TotalDeBonificacao += diretor.GetBonificacao();
        //}
    }
}
