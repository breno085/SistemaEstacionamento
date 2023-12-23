string opcao;
bool exibirMenu = true;

do
{   
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");
    
    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
        Console.WriteLine("tbd");
        break;

        case "2":
        Console.WriteLine("tbd");
        break;

        case "3":
        Console.WriteLine("tbd");
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
