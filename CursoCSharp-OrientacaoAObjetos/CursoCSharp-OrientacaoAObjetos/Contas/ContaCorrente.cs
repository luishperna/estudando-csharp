using CursoCSharp_OrientacaoAObjetos.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_OrientacaoAObjetos.Contas
{
    public class ContaCorrente
    {
        // Membro estático
        // Com static a propriedade passa a ser da classe e não dos objetos criados a partir dela
        public static int TotalDeContasCriadas { get; private set; }

        private int numeroAgencia;
        // Propriedade pública
        public int NumeroAgencia
        {
            get { return this.numeroAgencia; }
            private set { 
                    if (value > 0)
                    {
                        this.numeroAgencia = value;
                    }
                }    
        }

        // Propriedade autoimplementada 
        // private string conta;
        public string Conta { get; set; }

        // Campo privado para ser acessado por métodos públicos
        private double saldo = 100;

        // Propriedade autoimplementada 
        //private Cliente titular;
        public Cliente Titular { get; set; }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        // Método público para acessar campo privado
        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        // Método público para acessar campo privado
        public double GetSaldo()
        {
            return saldo;
        }

        public void ExibirTodasInformacoes()
        {
            Console.WriteLine("Todas as informações referete a conta de {0}:", Titular);
            Console.WriteLine("-> " + Titular);
            Console.WriteLine("-> " + Conta);
            Console.WriteLine("-> " + numeroAgencia);
            Console.WriteLine("-> " + saldo);
        }

        // Método construtor da classe ContaCorrente
        // Cria o objeto na memória
        public ContaCorrente(int numeroAgencia, string numeroConta)
        {
            this.NumeroAgencia = numeroAgencia;
            this.Conta = numeroConta;
            TotalDeContasCriadas++;
        }

        // Criando objetos com todas as informações da conta corrente
        public ContaCorrente(Cliente titular, int numeroAgencia, string conta)
        {
            this.Titular = titular;
            this.NumeroAgencia = numeroAgencia;
            this.Conta = conta;
            TotalDeContasCriadas++;
        }
    }
}
