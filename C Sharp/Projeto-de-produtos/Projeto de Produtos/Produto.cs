namespace Projeto_de_Produtos
{
    
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime data = DateTime.Now;
        public Marca Marca = new Marca();
        public string CadastradoPor { get; set; }
       
        List<Produto> listadeprodutos = new List<Produto>();

        public void Cadastrar()
        {
            Console.WriteLine($"CADASTRAR UM PRODUTO");
            Produto novoproduto = new Produto();

            Console.WriteLine($"Digite o código do produto");
            novoproduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome do produto");
            novoproduto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Digite o preco do produto");
            novoproduto.Preco = float.Parse(Console.ReadLine());

    
            novoproduto.Marca = Marca.CadastrarMarca();

            Console.WriteLine($"Digite quem cadastrou o produto");
            novoproduto.CadastradoPor = Console.ReadLine();

            novoproduto.data = DateTime.Now;

            Console.WriteLine($"PRODUTO CADASTRADO");

            listadeprodutos.Add(novoproduto);


        }
        public void Listar()
        {
            if (listadeprodutos.Count != 0)
            {


                Console.WriteLine($"Produtos Cadastrados:");

                foreach (var p in listadeprodutos)
                {
                    Console.WriteLine($@"
               Codigo do produto:  {p.Codigo}
               Nome do produto:    {p.NomeProduto}
               Preço do produto:   {p.Preco}
               Marca do produto:   {p.Marca.NomeMarca}
               Data do cadastro:   {p.data}
               Cadastrado por:     {p.CadastradoPor}
                ");

                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Nao possui nenhum item na lista");
                Console.ResetColor();
            }
        }
        public void Deletar(int codigo)
        {
            Produto produtoEncontrado = listadeprodutos.Find(x => x.Codigo == codigo);

            listadeprodutos.Remove(produtoEncontrado);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Produto deletado");
            Console.ResetColor();

        }

    }
}