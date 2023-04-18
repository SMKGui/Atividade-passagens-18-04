// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

//Algoritmo
//lista para armazenar nomes, origens, destinos e datas
//validacao da senha - entrada de senha pelo usuario
//menu de opcoes
//opcao de cadastrar novas passagens
//menu de opcoes
//opcao de cadastrar novas passagens

//criando as funcoes

//estrutura de uma funcao

//tipo tipoDado nomeFuncao(parametros ou argumentos)
{
    //Corpo da funcao
}

//funcao para verificar senha
static bool Login(string senha)
{
    if (senha == "123456")
    {
        return true;
    }
    else
    {
        Console.WriteLine($"Senha incorreta!");
        return false;
    }
}

//declarar variaveis
string[] nomes = new string[2];
string[] origens = new string[2];
string[] destinos = new string[2];
string[] data = new string[2];

bool senhaValida;


do
{
    Console.WriteLine($"Informe a sua senha: ");
    string senha = Console.ReadLine();
    senhaValida = Login(senha);

} while (senhaValida == false);

string opcao = Console.ReadLine();

do
{
//criar menu de opcoes
Console.WriteLine($"Menu de opcoes");
Console.WriteLine(@$"
Selecione uma das opcoes
[1] - Cadastrar
[2] - Listar
[0] - Sair
");

} while (opcao != "0");


switch (opcao)
{
    case "1":
        string resposta;
        do
        {

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Informe o nome: ");
                nomes[i] = Console.ReadLine();

                Console.WriteLine($"Informe a origem: ");
                origens[i] = Console.ReadLine();

                Console.WriteLine($"Informe o destino: ");
                destinos[i] = Console.ReadLine();

                Console.WriteLine($"Informe a data: ");
                data[i] = Console.ReadLine();
            }

            Console.WriteLine($"Deseja cadstrar mais passagens? s/n");
            resposta = Console.ReadLine().ToLower();

        } while (resposta == "s");
        break;

    case "2":

        for (var i = 0; i < 2; i++)
        {
            Console.WriteLine(@$"
            *******************
            Passagens - Bilhete

            Nome: {nomes[i]}
            Origem: {origens[i]}
            Destino: {destinos[i]}
            Data: {data[i]}
            ");
        }
        break;

    case "0":
        Console.WriteLine($"Fim do programa.");
        break;
    default:
        Console.WriteLine($"Opcao invalida!");
        break;
}