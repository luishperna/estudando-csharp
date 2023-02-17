﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_UsandoHerancaEImplementandoInterfaces.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000)
        {
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
