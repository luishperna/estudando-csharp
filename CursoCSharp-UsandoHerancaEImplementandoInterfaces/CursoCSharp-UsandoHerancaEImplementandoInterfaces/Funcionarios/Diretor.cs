using CursoCSharp_UsandoHerancaEImplementandoInterfaces.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_UsandoHerancaEImplementandoInterfaces.Funcionarios
{
    // Implementando Herança com ":" => Herda todas as propriedades e métodos públicos de outra classe
    // Importante para reaproveitar código
    public class Diretor : FuncionarioAutenticavel
    {

        // override => Informa que esse método irá reescrito
        public override double GetBonificacao()
        {
            // base => permite acessar propriedades e métodos existentes na classe base (herança)
            //return this.Salario + base.GetBonificacao();
            return this.Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        // Passando o cpf da classe Diretor para a classe base Funcionario
        public Diretor(string cpf):base(cpf, 5000)
        {
            //Console.WriteLine("Criando um diretor.");
        }
      
    }
}
