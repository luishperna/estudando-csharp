using CursoCSharp_UsandoHerancaEImplementandoInterfaces.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_UsandoHerancaEImplementandoInterfaces.SistemaInterno
{
    // Interface definir apenas propriedades e assinatura de comportamentos (estrutura de métodos)
    // Interface, assim como classe abstrata, não pode ser instanciada (criar objetos a partir dela)
    public interface IAutenticavel
    {
        public string Senha { get; set; }

        // Por padrão um método de uma interface é abstrato
        public bool Autenticar(string senha);

    }
}
