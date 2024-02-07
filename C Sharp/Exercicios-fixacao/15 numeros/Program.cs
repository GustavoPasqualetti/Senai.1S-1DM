int[] numeros = new int[15];

for (var i = 0; i < 14; i++)
{
    Console.WriteLine($"Digite o {i + 1}º numero");
    numeros[i] = int.Parse(Console.ReadLine());
    
}

Console.WriteLine($"Numeros registrados");

Console.WriteLine($"Numeros dados ao contrario");


for (var i = 14; i >= 0; i--)
{
    Console.WriteLine(numeros[i]);
    
}