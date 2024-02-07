Console.WriteLine($"Digite sua nota: ");
int nota = int.Parse(Console.ReadLine());

while (nota > 10 || nota < 0)
{
    Console.WriteLine($"Nota invalida, sua nota deve ser de 0-10 ");
    nota = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Nota registrada");
