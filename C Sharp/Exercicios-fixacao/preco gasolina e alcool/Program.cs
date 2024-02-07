Console.WriteLine($"Bem vindo ao Posto de Combustivel");


Console.WriteLine(@$"Qual combustivel deseja:
(g) Gasolina = R$5.30 - litro
(a) Alcool   = R$4.90 - litro
");
string combustivel = Console.ReadLine();

Console.WriteLine($"Quantos litros deseja colocar?");
float litros = float.Parse(Console.ReadLine());

if (combustivel == "g" && litros <=20 )
{
    Console.WriteLine($"Sua conta deu {litros * 5.30 * 0.96}");
    
}

if (combustivel == "g" && litros > 20 )
{
    Console.WriteLine($"Sua conta deu {litros * 5.30 * 0.94}");
    
}

if (combustivel == "a" && litros <= 20 )
{
    Console.WriteLine($"Sua conta deu {litros * 4.90 * 0.97}");
    
}

if (combustivel == "a" && litros > 20 )
{
    Console.WriteLine($"Sua conta deu {litros * 4.90 * 0.95}");
    
}
