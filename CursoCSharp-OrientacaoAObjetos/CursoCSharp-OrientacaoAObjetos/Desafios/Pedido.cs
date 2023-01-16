using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_OrientacaoAObjetos.Desafios
{
    public class Pedido
    {
        public int numero_Pedido;
        public Cliente cliente;
        public ItemPedido item;
        public float total_Pedido;
    }

    public class ItemPedido
    {
        public int quantidade;
        public int numero_Pedido;
        public Produto produto1;
        public Produto produto2;
        public Produto produto3;
    }

    public class Produto
    {
        int codigo_Produto;
        string Descricao;
        double valor_Unitario;
        double quantidade;
    }
    public class Cliente
    {
        public string nome;
        public string cpf;
        public string email;
        public Endereco endereco;
    }

    public class Endereco
    {
        public string rua;
        public string bairro;
        public string cidade;
        public string cep;
        public int numero;
    }

}
