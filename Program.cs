using _EAD__04_12_;

Produto produto = new Produto();

bool ativo = true;
bool produto2 = false;

while (ativo)
{
    Console.WriteLine("1 - Cadastrar produto\n2 - Exibir produto\n3 - Exibir valor total em estoque\n4 - Sair");
    Console.WriteLine("Selecione uma categoria");
    int opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 1:
            Console.WriteLine("Digite o nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto: R$");
            produto.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de produtos: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Produto cadastrado");
            produto2 = true;
            break;

        case 2:
            if (produto2 == false)
            {
                Console.WriteLine("Não há nenhum produto cadastrado.");
            }
            else
            {
                Console.WriteLine("Dados do produto: ");
                Console.WriteLine($"Nome: {produto.Nome} Preço: {produto.Preco}Quantidade: {produto.Quantidade}");
            }
            break;

        case 3:
            if (produto2 == false)
            {
                Console.WriteLine("Não há nenhum produto cadastrado");
            }
            else
            {
                Console.WriteLine($"Valor total em estoque {produto.ValorTotal()}");
    
            }

            break;

        case 4:
            Console.WriteLine("Programa encerrado");
            ativo = false;
            break;
    }
}
