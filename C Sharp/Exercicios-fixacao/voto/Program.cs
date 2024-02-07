static int Votar(int n1, int n2)
{
    return (n1 - n2);
}
Console.WriteLine($"Informe o ano que estamos");
int ano = int.Parse(Console.ReadLine());

Console.WriteLine($"Em que ano você nasceu?");
int nascimento = int.Parse(Console.ReadLine());

int resposta = ano - nascimento;

if (resposta >= 16)
{
    Console.WriteLine($"Voce poderá votar este ano!");
    
}

else
{
    Console.WriteLine($"voce nao poderá votar este ano!");
    
}