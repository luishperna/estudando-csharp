/* Para utilizar a classe criada em outro arquivo, precisa-se informar o 
namespace onde encontra-se a classe, como mostrado abaixo: */

using CursoCSharp_OrientacaoAObjetos;
using CursoCSharp_OrientacaoAObjetos.Contas;
using CursoCSharp_OrientacaoAObjetos.Desafios;
using CursoCSharp_OrientacaoAObjetos.Titular;
using System.Numerics;

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numeroAgencia = 15;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.saldo = 100;
//Console.WriteLine("Saldo da conta do André = {0}", contaDoAndre.saldo);

//contaDoAndre.ExibirTodasInformacoes();

//ContaCorrente contaDoAndre2 = new ContaCorrente();
//contaDoAndre2.titular = "André Silva";
//contaDoAndre2.numeroAgencia = 15;
//contaDoAndre2.conta = "1010-X";
//contaDoAndre2.saldo = 100;
//Console.WriteLine("Saldo da conta do André = {0}", contaDoAndre2.saldo);

//contaDoAndre = contaDoAndre2;

//Console.WriteLine(contaDoAndre == contaDoAndre2);

//contaDoAndre.Depositar(100);

//Console.WriteLine("Saldo da conta do André pós-deposito = {0}", contaDoAndre.saldo);

//if (contaDoAndre.Sacar(150))
//{
//    Console.WriteLine("Saldo da conta do André pós-saque = {0}", contaDoAndre.saldo);
//}
//else
//{
//    Console.WriteLine("Saldo insuficiente para saque.");
//}

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numeroAgencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo= 350;

//Console.WriteLine("Saldo da conta do {0} = {1}", contaDaMaria.titular, contaDaMaria.saldo);

//string linhas = new string('-', 30);
//Console.WriteLine(linhas);

//contaDoAndre.Transferir(50, contaDaMaria);
//Console.WriteLine("Saldo do {0} = {1}", contaDoAndre.titular, contaDoAndre.saldo);
//Console.WriteLine("Saldo do {0} = {1}", contaDaMaria.titular, contaDaMaria.saldo);

//Console.WriteLine(linhas);

//Pessoa pessoa = new Pessoa();

//Console.WriteLine("1 - " + pessoa.nome);
//Console.WriteLine("2 - " + pessoa.idade);
//Console.WriteLine("3 - " + pessoa.altura);
//Console.WriteLine("4 - " + pessoa.peso);

// Em uma classe os valores de tipos:
// -> númericos assumem o valor padrão 0 (zero)
// -> string assumem o valor padrão null (nulo)
// -> bool assumem o valor padrão false (falso)

//ContaCorrente contaDoPedro = new ContaCorrente();

//contaDoPedro.titular = "Pedro Silva";
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numeroAgencia);
//Console.WriteLine(contaDoPedro.conta);

// Tipagem ou Tipo por valor o conteúdo (valor atribuido na variável anterior) é copiado para a nova variável
// *para tipos primitivos
//double valor = 300;
//double valor2 = valor;

//Console.WriteLine(valor == valor2);
//Console.WriteLine(valor);   // Saída 300
//Console.WriteLine(valor2);  // Saída 300

// Tipagem ou Tipo por referência
// *para tipos mais complexos, como classes e objetos

//ContaCorrente conta = new ContaCorrente();

//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "123456789";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();

//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numeroAgencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = {0}", conta.titular.nome);
//Console.WriteLine("CPF = {0}", conta.titular.cpf);
//Console.WriteLine("Profissão = {0}", conta.titular.profissao);
//Console.WriteLine("Nº Conta = {0}", conta.conta);
//Console.WriteLine("Saldo = {0}", conta.saldo);
//Console.WriteLine("Nº Agência = {0}", conta.numeroAgencia);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "Luís Perna";
//conta2.titular.profissao = "Desenvolvedor";
//conta2.titular.cpf = "321654987";
//conta2.conta = "9999-X";
//conta2.numeroAgencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.NumeroAgencia = 18;
//conta3.Conta = "1011-H";
//conta3.SetSaldo(200);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.NumeroAgencia);
//Console.WriteLine(conta3.Conta);

//ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();
//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.NumeroAgencia);

//ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
//// Propriedade static é acessa na classe e não no objeto criado
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

//ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

//ContaCorrente conta7 = new ContaCorrente(285, "1111-Y");
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

//Console.WriteLine("-- Contabilizando Clientes --");

//Cliente sarah = new Cliente();
//sarah.Nome = "Sarah Silva";
//sarah.Profissao = "Professora";
//sarah.Cpf = "11111111-12";

//Cliente ester = new Cliente();
//ester.Nome = "Ester Almeida";
//ester.Profissao = "Advogada";
//ester.Cpf = "868524125-32";

//Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);

//ContaCorrente contaAndre = new ContaCorrente(159, "152869-x");
//contaAndre.Titular = new Cliente();
//contaAndre.Titular.Nome = " André Pereira";
//contaAndre.Titular.Profissao = "Auxiliar Administrativo";
//contaAndre.SetSaldo(100);

//Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);

/*
try
{
    ContaCorrente conta1 = new ContaCorrente(0, "1234-X");
  
    conta1.Sacar(50);
    Console.WriteLine(conta1.GetSaldo());
    conta1.Sacar(150);
    Console.WriteLine(conta1.GetSaldo());
    
} 
catch(ArgumentException ex)
{
    // Mostrando o parâmetro que entrou na exceção
    Console.WriteLine("Parâmetro com erro: " + ex.ParamName);
    Console.WriteLine("Não é possível criar uma conta com o número de " +
                      "agência menor ou igual a zero");

    // Mostra o arquivo e linha onde está sendo tratada a exceção e na outra onde foi encontrada a exceção 
    Console.WriteLine(ex.StackTrace);

    // Mostrando mensagem de exceção lançada (throw)
    Console.WriteLine(ex.Message);
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine("Operação negada! Saldo insuficiente!");
    Console.WriteLine(ex.Message);
}
*/

LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");

try
{
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
}
catch(IOException)
{
    Console.WriteLine("Leitura de arquivo interrompida!");
}
finally
{
    // Fecha o arquivo para não corromper, independente de encontrar ou não uma exceção
    leitor.Dispose();
}

// syntax sugar (açúcar sintático) => using
/*
using (LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
{
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
}
*/