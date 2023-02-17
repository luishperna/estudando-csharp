using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_UsandoHerancaEImplementandoInterfaces.Funcionarios
{
    // Classe abstrata não possibilita a criando de objetos (instanciar objetos) a partir dela,
    // ela serve como modelo para criação de outras classes.
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }

        // protected => Visível na própria classe e nas classes que herdam
        public double Salario { get; protected set; }

        public static int TotalDeRFuncionarios { get; private set; }

        // Sobrescrita de método (virtual) => Qualquer classe que herde de Funcionario
        // poderá reescrever esse método.

        // Método abstrato => Não tem implementação nessa classe.
        // Toda classe que herdar de Funcionario deverá implemetar este método
        // Na classe abstrata deve ser informado a assinatura do método (nome) + abstract
        public abstract double GetBonificacao();

        public abstract void AumentarSalario();

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDeRFuncionarios++;
            //Console.WriteLine("Criando um funcionário.");
        }

    }

}
