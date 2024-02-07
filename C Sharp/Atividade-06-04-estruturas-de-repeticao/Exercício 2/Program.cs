Console.WriteLine($"Informe seu usuário");
string usuario = Console.ReadLine();

Console.WriteLine($"Informe sua senha");
string senha = Console.ReadLine();

while (senha == usuario)
{
    Console.WriteLine($"Sua senha nao pode ser a mesma que o usuario");
    senha = Console.ReadLine();
}

Console.WriteLine($"Cadastro realizado");

