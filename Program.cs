using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

string opcao;
bool exibirMenu = true;
decimal precoInicial;
decimal precoPorHora;
List<string> placasDeVeiculos = new List<string>();

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");

Console.WriteLine("Digite o preço inicial:");
precoInicial = decimal.Parse(Console.ReadLine());

Console.WriteLine("Agora digite o preço pro hora:");
precoPorHora = decimal.Parse(Console.ReadLine());

do
{   
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    
    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
        CadastrarVeiculo();
        break;

        case "2":
        RemoverVeiculos();
        break;

        case "3":
        ListarVeiculos();
        break;

        case "4":
        // Environment.Exit(0); //obs: isso terminar a exucução do programa, não só do loop
        exibirMenu = false;
        break;

        default:
        Console.WriteLine("tbd");
        break;
    }
    Console.WriteLine("Pressione enter para continuar");
    Console.ReadLine();

} while (exibirMenu);

void CadastrarVeiculo()
{   
    string placaVeiculo;
    
    Console.WriteLine("Digite a placa do veículo para estacionar:");
    placaVeiculo = Console.ReadLine();
    
    placasDeVeiculos.Add(placaVeiculo);
}

void ListarVeiculos()
{
    foreach(string item in placasDeVeiculos)
    {
        Console.WriteLine(item);
    }
}

void RemoverVeiculos()
{
    string placaRemovida;

    do
    {
    Console.WriteLine("Digite a placa do veículo para remover");
    placaRemovida = Console.ReadLine();

    if (!placasDeVeiculos.Contains(placaRemovida))
    {
        Console.WriteLine("Digite uma placa válida!");
    } 
    else
    {
        placasDeVeiculos.Remove(placaRemovida);

        Console.WriteLine("Digite a quantidade de horas que o veículo ficou estacionado:");
        double horas = double.Parse(Console.ReadLine());

        Console.WriteLine($"O Veículo {placaRemovida} foi removido e o preço total "
        + $"foi de: {precoTotal(horas, precoInicial, precoPorHora):C}");
    }

    } while (placasDeVeiculos.Contains(placaRemovida));
}

decimal precoTotal(double horas, decimal precoInicial, decimal precoPorHora)
{
    return precoInicial + (decimal) horas*precoPorHora;
}
