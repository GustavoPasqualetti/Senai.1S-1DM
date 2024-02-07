namespace Projeto_de_Produtos
{
    using Projeto_de_Produtos;
    public class Marca
    {

        
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime data = DateTime.Now;

        List<Marca> listaDeMarcas = new List<Marca>();


        public Marca CadastrarMarca()
        {
            Console.WriteLine($"CADASTRAR MARCAS");
            Marca novamarca = new Marca();

            Console.WriteLine($"Digite o código da marca");
            novamarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome da marca");
            novamarca.NomeMarca = Console.ReadLine();

            novamarca.data = DateTime.Now;

            listaDeMarcas.Add(novamarca);
            return novamarca;
        }

       



        public void Listar()
        {
            Produto pdt = new Produto();

               

            if (listaDeMarcas.Count != 0 )
            {

                Console.WriteLine($"Produtos Cadastrados:");

                foreach (var b in listaDeMarcas)
                {
                    Console.WriteLine($@"
             Marcas Registradas:
             Código:          {b.Codigo}
             Nome da Marca:   {b.NomeMarca}
             Data:            {b.data}
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
            Marca marcaEncontrado = listaDeMarcas.Find(x => x.Codigo == codigo);

            listaDeMarcas.Remove(marcaEncontrado);
            Console.WriteLine($"Produto deletado");
        }
    }
}