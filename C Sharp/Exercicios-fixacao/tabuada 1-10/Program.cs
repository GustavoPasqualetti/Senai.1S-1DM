Console.WriteLine($"Pressione qualquer tecla para ver a tabuada do 1 ao 10");

for (var i = 1; i <= 10; i++)
{
    for (var z = 1; z <= 10; z++)
    {
        Console.WriteLine($"{i} x {z} = {i * z}");
        
    }
}