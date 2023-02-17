﻿using CursoCSharp_UsandoHerancaEImplementandoInterfaces.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_UsandoHerancaEImplementandoInterfaces.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Senha { get ; set ; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
