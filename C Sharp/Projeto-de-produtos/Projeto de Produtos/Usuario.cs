namespace Projeto_de_Produtos
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        private DateTime Data = DateTime.Now;
        public void CadastrarUsuario()
        {
            Console.WriteLine($"Informe seu nome:");
            Nome = Console.ReadLine();
            Console.WriteLine($"Informe seu email:");
            Email = Console.ReadLine();
            Console.WriteLine($"Informe sua senha:");
            Senha = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"USUÁRIO CADASTRADO");
            Console.ResetColor();
            Console.WriteLine($"Pressione Enter para se logar");
            string enter = Console.ReadLine();
            
            this.Data = DateTime.Now;

        }

        public void DeletarUsuario()
        {
            this.Nome = "";
            this.Email = "";
            this.Senha = "";
            this.Data = DateTime.Parse("0000-00-00T0000:00:00");
        }
    }

}
