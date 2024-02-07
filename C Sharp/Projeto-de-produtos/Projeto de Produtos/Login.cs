namespace Projeto_de_Produtos
{
    public class Login
    {

        public bool logado { get; set; }

        public Login()
        {


            Usuario usuario = new Usuario();

            usuario.CadastrarUsuario();

            Logar(usuario);
        }

        public void Logar(Usuario usuario)
        {
            do
            {


                Console.WriteLine($"Informe seu email:");
                string email = Console.ReadLine();

                Console.WriteLine($"Informe sua senha:");
                string senha = Console.ReadLine();

                if (email == usuario.Email && senha == usuario.Senha)
                {
                    this.logado = true;
                    Console.WriteLine($"Login efetuado com sucesso");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    BarraCarregamento("Logando em sua conta", 5, 200);
                    Console.ResetColor();
                    GerarMenu();
                    
                }
                else
                {
                    this.logado = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Falha no login");
                    Console.ResetColor();
                }
            } while (logado != true);
        }

        public void Deslogar(Usuario usuario)
        {

        }

        static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
        {
            Console.Write(texto);

            for (var i = 0; i < quantidadePontinhos; i++)
            {
                Console.Write($".");
                Thread.Sleep(tempo);
            }
        }

        int opcao;
        public void GerarMenu()
        {

            Produto produto = new Produto();
            Marca marca = new Marca();

            do
            {
                Console.WriteLine($"");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($@"
                  |------MENU DE OPCOES------|
                  |                          |
                  |[1] CADASTRAR PRODUTO     |
                  |[2] LISTAR PRODUTOS       |
                  |[3] DELETAR PRODUTO       |
                  |                          |
                  |--------------------------|
                  |                          |
                  |[4] CADASTRAR MARCAS      |
                  |[5] LISTAR MARCAS         |
                  |[6] DELETAR MARCAS        |
                  |                          |
                  |--------------------------|
                  |                          |
                  |[0] SAIR DO SISTEMA       |

                "); opcao = int.Parse(Console.ReadLine());
                Console.ResetColor();
            
                switch (opcao)
                {
                    case 1:
                        produto.Cadastrar();
                        break;
                    case 2:
                        produto.Listar();
                        break;
                    case 3:
                        Console.WriteLine($"Informe o código a ser deletado");
                        int codigoProduto = int.Parse(Console.ReadLine());

                        produto.Deletar(codigoProduto);
                        break;
                    case 4:
                        marca.CadastrarMarca();
                        break;
                    case 5:
                        marca.Listar();
                        break;
                    case 6:
                        Console.WriteLine($"Informe o código a ser deletado");
                        int codigoMarca = int.Parse(Console.ReadLine());

                        marca.Deletar(codigoMarca);
                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        BarraCarregamento("Saindo do sistema", 5, 200);
                        Console.ResetColor();

                        break;
                    default:
                        break;
                }

            } while (opcao != 0);

        }

    }


}