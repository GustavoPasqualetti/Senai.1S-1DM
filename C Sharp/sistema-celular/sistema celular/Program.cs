using sistema_celular;

Celular cel = new Celular();

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"Digite a cor do Celular");
cel.cor = Console.ReadLine();

Console.WriteLine($"Digite o modelo do Celular");
cel.modelo = Console.ReadLine();

Console.WriteLine($"Digite o tamanho do Celular");
cel.tamanho = Console.ReadLine();


Console.WriteLine(@$"
Ligar o celular?  
    S/N");
Console.ResetColor();
string ligado = Console.ReadLine();

if (ligado == "s")
{
    Console.ForegroundColor = ConsoleColor.Green;
    cel.Ligar();
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(@$"Oque deseja fazer no celular?
1- Fazer uma ligacao
2- Enviar uma mensagem 
0- Desligar
");
    Console.ResetColor();
    string acoes = Console.ReadLine();

    switch (acoes)
    {
        case "1":
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Para quem você deseja ligar?");
            Console.ResetColor();
            cel.pLigacao = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            cel.FazerLigacao();
            Console.ResetColor();
            break;

        case "2":
        Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Para quem você deseja mandar mensagem?");
            Console.ResetColor();
            cel.pMensagem = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            cel.EnviarMensagem();
            Console.ResetColor();
            break;

        case "0":
            Console.ForegroundColor = ConsoleColor.Red;
            cel.Desligar();
            Console.ResetColor();
            break;
    }

}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    cel.Desligar();
    Console.ResetColor();
}









