Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(@$"Boa tarde, nossa loja esta com promocoes! 
Travesseito confort plus 
Preco unitario = R$200
Quantos dos nossos produtos voce deseja comprar?
");
Console.ResetColor();
int quantidade = int.Parse(Console.ReadLine());

if (quantidade <= 5)
{
    Console.WriteLine($"Estamos com um desconto de 2%");
    Console.WriteLine($"Sua compra deu {quantidade * 200 * 0.98}");
    
}

if (quantidade > 5 && quantidade <= 10)
{
    Console.WriteLine($"Estamos com um desconto de 3%");
    Console.WriteLine($"Sua compra deu {quantidade * 200 * 0.97}");
    
}

if (quantidade > 10)
{
    Console.WriteLine($"Estamos com um desconto de 5%");
    Console.WriteLine($"Sua compra deu {quantidade * 200 * 0.95}");
    
}