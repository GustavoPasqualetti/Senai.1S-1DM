int[] numeros= new int[10];
int maior = 0;
int menor = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i + 1}º numero ");
    numeros[i] = int.Parse(Console.ReadLine());

if (i == 0)
{
    maior = numeros[i];
    menor = numeros[i];
}
else
{
    if (numeros[i] > maior)
    {
        maior = numeros[i];
    }
    if (numeros[i] < menor)
    {
        menor = numeros[i];
    }
}
}

Console.WriteLine($"Maior valor: {maior}");
Console.WriteLine($"Menor valor: {menor} ");