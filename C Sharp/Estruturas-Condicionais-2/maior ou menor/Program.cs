Console.WriteLine($"Digite o primeiro número");
float n1= float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo número");
float n2= float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o terceiro número");
float n3= float.Parse(Console.ReadLine());

if( n1> n2 && n1 > n3)
{
Console.WriteLine($"{n1} é o maior");

}

if (n2 > n1 && n2 > n3)
{
    Console.WriteLine($"{n2} é o maior");
    
}

if (n3 > n2 && n3 > n1)
{
    Console.WriteLine($"{n3} é o maior");
    
}

if (n1 < n2 && n1 < n3) 
{
Console.WriteLine($"{n1} é o menor");

}

if (n2 < n1 && n2 < n3)
{
    Console.WriteLine($"{n2} é o menor");
    
}

if (n3 < n1 && n3 < n2)
{
    Console.WriteLine($"{n3} é o menor");
    
}
