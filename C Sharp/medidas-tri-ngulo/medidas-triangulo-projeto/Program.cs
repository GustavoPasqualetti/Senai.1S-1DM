
Console.WriteLine($"Informe o tamanho do primeiro lado do seu triângulo:");
float lado1= float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o tamanho do segundo lado do seu triângulo:");
float lado2= float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o tamanho do terceiro lado do seu triângulo:");
float lado3= float.Parse(Console.ReadLine());



if ( lado1 == lado2 && lado2 == lado3 )
{
    Console.WriteLine($"O triângulo é Equilátero");
    
}

else if ( lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
Console.WriteLine($"O triângulo é Isósceles");

}

else
{
    Console.WriteLine($"O triângulo é Escaleno");
    
}

