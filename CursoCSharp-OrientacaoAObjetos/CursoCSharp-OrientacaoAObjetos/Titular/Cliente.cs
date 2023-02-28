using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_OrientacaoAObjetos.Titular
{
    public class Cliente
    {

        // Propriedade estática
        public static int TotalClientesCadastrados { get; set; }

        // Propriedades auto implementadas
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        // Método construtor da classe Cliente
        public Cliente()
        {
            TotalClientesCadastrados++;
        }

        //public override string ToString()
        //{
        //    return $"Nome: {this.Nome},\n" +
        //           $"CPF: {this.Cpf},\n" +
        //           $"Profissao: {this.Profissao}";
        //}
    }
}