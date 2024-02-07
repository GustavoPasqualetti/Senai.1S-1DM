Console.WriteLine($"Infome quantos gols o primeiro time fez");
int time1= int.Parse(Console.ReadLine());

Console.WriteLine($"Infome quantos gols o segundo time fez");
int time2= int.Parse(Console.ReadLine());

if (time1 > time2)
{
    Console.WriteLine($"A vitoria foi do primeiro time");
    
}

else if (time1 == time2)
{
Console.WriteLine($"O jogo acabou empatado");

}

else
{
    Console.WriteLine($"A vitoria foi do segundo time");
    
}

