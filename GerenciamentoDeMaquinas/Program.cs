using GerenciamentoDeMaquinas.Models;

bool exibirMenu = true;

Gerenciamento gerenciamento = new Gerenciamento();

while (exibirMenu)
{
    Console.WriteLine("Seja bem vindo!");
    Console.WriteLine("Digite um número para navegar no sistema");
    Console.WriteLine("\n1 - Adicionar Máquina\n2 - Alterar Máquina\n3 - Remover Máquina\n4 - Buscar Máquina\n5 - Listar Todas Máquinas");
    Console.Write(">> ");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            gerenciamento.AdicionarMaquina();
            break;

        case "2":
            break;

        case "3":
            break;

        case "4":
            break;

        case "5":
            break;
    }
}
