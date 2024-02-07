Console.BackgroundColor= ConsoleColor.DarkCyan;
Console.WriteLine($"Menu de Bebidas");

Console.WriteLine($"Escolha a bebide que deseja: ");
Console.WriteLine($"1- Coca-cola");
Console.WriteLine($"2- Água");
Console.WriteLine($"3- Energético");
Console.WriteLine($"4- Chá gelado");
Console.ResetColor();

string bebidaEscolhida = Console.ReadLine();

Console.WriteLine($"Deseja adicionar gelo na bebida?");
string Gelo = Console.ReadLine().ToLower();

switch (bebidaEscolhida)
{
    case "1":
Console.BackgroundColor= ConsoleColor.Green;
        if (Gelo == "sim")
            Console.WriteLine($"Seu pedido: Coca-cola com gelo");

        else
        {
            Console.WriteLine($"Seu pedido: Coca-cola sem gelo");
        }
Console.ResetColor();
        break;

 case "2":
Console.BackgroundColor= ConsoleColor.Green;
        if (Gelo == "sim")
            Console.WriteLine($"Seu pedido: Água com gelo");

        else
        {
            Console.WriteLine($"Seu pedido: Água sem gelo");
        }
Console.ResetColor();
        break;

case "3":
Console.BackgroundColor= ConsoleColor.Green;
        if (Gelo == "sim")
            Console.WriteLine($"Seu pedido: Energético com gelo");

        else
        {
            Console.WriteLine($"Seu pedido: Energético sem gelo");
        }
Console.ResetColor();
        break;

case "4":
Console.BackgroundColor= ConsoleColor.Green;
        if (Gelo == "sim")
            Console.WriteLine($"Seu pedido: Chá gelado com gelo");

        else
        {
            Console.WriteLine($"Seu pedido: Chá gelado sem gelo");
        }
Console.ResetColor();
        break;
}








