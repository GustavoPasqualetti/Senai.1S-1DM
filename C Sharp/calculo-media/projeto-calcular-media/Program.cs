Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine($@"
-------------------
|  Programa para  |
|  calcular sua   |
|      media      |
-------------------"); Console.ResetColor();


Console.Write($"Digite sua primeira nota: ");
float nota1 = float.Parse(Console.ReadLine());

Console.Write($"Digite sua segunda nota: ");
float nota2 = float.Parse(Console.ReadLine());

Console.Write($"Digite sua terceira nota: ");
float nota3 = float.Parse(Console.ReadLine());

Console.Write($"Digite sua quarta nota: ");
float nota4 = float.Parse(Console.ReadLine());

Console.Write($"Digite sua quinta nota: ");
float nota5 = float.Parse(Console.ReadLine());

float notas = nota1 + nota2 + nota3 + nota4 + nota5;

float media = notas / 5;

Console.WriteLine($"Sua média e {media}");


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Obrigado por utilizar nosso sistema");
Console.ResetColor();




