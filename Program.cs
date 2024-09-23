using TDE_POO;

Inventario inventario = new Inventario();
int opcao;

do
{
    Console.WriteLine("Sistema de Gerenciamento de Inventário");
    Console.WriteLine("1. Adicionar Item");
    Console.WriteLine("2. Listar Itens");
    Console.WriteLine("3. Editar Item");
    Console.WriteLine("4. Remover Item");
    Console.WriteLine("5. Sair");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            AdicionarItem(inventario);
            break;
        case 2:
            inventario.ListarItens();
            break;
        case 3:
            EditarItem(inventario);
            break;
        case 4:
            RemoverItem(inventario);
            break;
        case 5:
            Console.WriteLine("Saindo do sistema...");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
} while (opcao != 5);
    

    static void AdicionarItem(Inventario inventario)
{
    Console.Write("Nome do item: ");
    string nome = Console.ReadLine();

    Console.Write("Quantidade: ");
    int quantidade = int.Parse(Console.ReadLine());

    Console.Write("Preço: ");
    decimal preco = decimal.Parse(Console.ReadLine());

    Item item = new Item(nome, quantidade, preco);
    inventario.AdicionarItem(item);
}

static void EditarItem(Inventario inventario)
{
    inventario.ListarItens();

    Console.Write("Digite o número do item que deseja editar: ");
    int index = int.Parse(Console.ReadLine()) - 1;

    Console.Write("Novo nome do item: ");
    string nome = Console.ReadLine();

    Console.Write("Nova quantidade: ");
    int quantidade = int.Parse(Console.ReadLine());

    Console.Write("Novo preço: ");
    decimal preco = decimal.Parse(Console.ReadLine());

    Item novoItem = new Item(nome, quantidade, preco);
    inventario.EditarItem(index, novoItem);
}

static void RemoverItem(Inventario inventario)
{
    inventario.ListarItens();

    Console.Write("Digite o número do item que deseja remover: ");
    int index = int.Parse(Console.ReadLine()) - 1;

    inventario.RemoverItem(index);
}