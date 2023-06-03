using byteBank_ADM.Funcionarios;
using byteBank_ADM.Parceria;
using byteBank_ADM.SistemaInterno;
using byteBank_ADM.Utilitario;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

#region Antiga Criacao
//Funcionario lucas = new Funcionario("06659493166", 3000);
//lucas.Nome = "Lucas Vieira";

//Console.WriteLine(lucas.Nome);
//Console.WriteLine("Salario normal: "+lucas.Salario);
//Console.WriteLine("Salario com bonificação: " + lucas.GetBonificacao());


//Diretor Mariana = new Diretor("12345678");
//Mariana.Nome = "Mariana Alves";

//Console.WriteLine(Mariana.Nome);
//Console.WriteLine("Salario normal: " + Mariana.Salario);
//Console.WriteLine("Salario com bonificação: " + Mariana.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(lucas);
//gerenciador.Registrar(Mariana);

//Console.WriteLine("Total de Bonificações: "+gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de Funcionários: "+Funcionario.TotalDeFuncionarios);

//lucas.AumentarSalario();
//Mariana.AumentarSalario();

//Console.WriteLine("Novo salario do Lucas: "+lucas.Salario);
//Console.WriteLine("Novo salario da Mariana: " + Mariana.Salario);
#endregion

//CHAMANDO O METODO PARA PODER FUNCIONAR
//CalcularBonificacao();
UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("5566");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("6655");
    paula.Nome = "Paula Silva";

    Auxiliar igor = new Auxiliar("1122");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("2211");
    camila.Nome = "Camila Almeida";

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine("Total de Bonificação = " + gerenciador.TotalDeBonificacao);
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("5555");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("6666");
    ursula.Nome = "Ursula Alcantra";
    ursula.Senha = "321";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "999";

    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "963");
    sistema.Logar(caio, "999");
}
