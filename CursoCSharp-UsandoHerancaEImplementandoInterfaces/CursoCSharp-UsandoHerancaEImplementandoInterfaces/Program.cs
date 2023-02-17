using CursoCSharp_UsandoHerancaEImplementandoInterfaces.DesafioClassesDeOperacoes;
using CursoCSharp_UsandoHerancaEImplementandoInterfaces.Funcionarios;
using CursoCSharp_UsandoHerancaEImplementandoInterfaces.Parceria;
using CursoCSharp_UsandoHerancaEImplementandoInterfaces.SistemaInterno;
using CursoCSharp_UsandoHerancaEImplementandoInterfaces.Utilitario;

#region
//// Inicializadores de objeto => Atribuindo valores do objeto junto a sua criação
//Funcionario pedro = new Funcionario("123456789", 2000)
//{
//    Nome = "Pedro Malazartes",
//    //Salario = 2000,
//};

//// [...]mesmo que:
////pedro.Nome = "Pedro Malazartes";
////pedro.Cpf = "123456789";
////pedro.Salario = 2000;

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("987654321")
//{
//    Nome = "Roberta Silva",
//    //Salario = 5000
//};

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine($"Total de bonificações: {gerenciador.TotalDeBonificacao}");
//Console.WriteLine($"Total de funcionários: {Funcionario.TotalDeRFuncionarios}");

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine($"Novo salário do Pedro: {pedro.Salario}");
//Console.WriteLine($"Novo salário do Roberta: {roberta.Salario}");
#endregion

#region
/* Desafio Classes De Operacoes:
 * Console.WriteLine("Olá, Boas Vindas ao Calculatrix!");
 * Operacoes operacoes = new Operacoes();
 * Console.WriteLine("O valor é: " + operacoes.Soma.Calcular(30, 15));
 * Console.WriteLine("O valor é: " + operacoes.Subtracao.Calcular(30, 15));
 * Console.WriteLine("O valor é: " + operacoes.Divisao.Calcular(30, 15));
 * Console.WriteLine("O valor é: " + operacoes.Multiplicacao.Calcular(30, 15));
 * Console.ReadKey();
*/
#endregion
// CalcularBonificacao();
UsarSistema();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("123456");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("987654");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("345678");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("765432");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine($"Total de Bonificação: {gerenciador.TotalDeBonificacao}");
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("432523")
    {
        Nome = "Ingrid Novaes",
        Senha = "1234"
    };

    GerenteDeContas ursula = new GerenteDeContas("876543")
    {
        Nome = "Ursula Alcantara",
        Senha = "4321"
    };

    ParceiroComercial caio = new ParceiroComercial()
    {
        Senha = "9999"
    };

    sistema.Logar(ingrid, "1234");
    sistema.Logar(ursula, "0000");
    sistema.Logar(caio, "9999");

}