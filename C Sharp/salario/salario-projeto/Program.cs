Console.Write($"Informe seu salário: ");
float salario= float.Parse(Console.ReadLine());

Console.Write($"Informe seu gasto: ");
float gasto= float.Parse(Console.ReadLine());


if (salario > gasto)
{
    Console.WriteLine($"seus gastos estão dentro de seu orçamento");
    
}
else
{
    Console.WriteLine($"seu orçamento está estourado");
    
}