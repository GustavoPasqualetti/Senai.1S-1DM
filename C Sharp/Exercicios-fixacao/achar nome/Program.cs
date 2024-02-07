string[] nomes = new string[10];

for (var i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i + 1}º nome");
    nomes[i] = Console.ReadLine();

}

Console.WriteLine($"Nomes registrados");

Console.WriteLine($"Digite um nome para realizarmos uma busca");
string busca = Console.ReadLine();

if (nomes.Contains(busca))
{
    Console.WriteLine($"Achei");

}
else
{
    Console.WriteLine($"Nao achei");
    
}
