using GerenciamentoDeMaquinas.Models;

bool exibirMenu = true;

Gerenciamento gerenciamento = new Gerenciamento();

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Seja bem vindo!");
    Console.WriteLine("Digite um número para navegar no sistema");
    Console.WriteLine("\n1 - Adicionar Máquina\n2 - Alterar Máquina\n3 - Remover Máquina\n4 - Buscar Máquina\n5 - Listar Todas Máquinas\n6 - Sair\n");
    Console.Write(">> ");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            gerenciamento.AdicionarMaquina();
            break;

        case "2":
            gerenciamento.AlterarMaquina();
            break;

        case "3":
            gerenciamento.RemoverMaquina();
            break;

        case "4":
            gerenciamento.BuscarMaquina();
            break;

        case "5":
            gerenciamento.ListarTodasMaquinas();
            break;

        case "6":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("\nFavor, digitar um número válido");
            Console.ReadKey();
            break;
    }
}