using CursoCSharp_UsandoHerancaEImplementandoInterfaces.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_UsandoHerancaEImplementandoInterfaces.Parceria
{
    public class ParceiroComercial : IAutenticavel
    {
       public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }

    }
}
