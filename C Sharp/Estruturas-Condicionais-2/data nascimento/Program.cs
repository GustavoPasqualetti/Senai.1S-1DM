Console.WriteLine($"Digite Informe o dia do seu nascimento ");
float dia= float.Parse(Console.ReadLine());

Console.WriteLine($"Digite Informe o mês do seu nascimento ");
float mes= float.Parse(Console.ReadLine());

Console.WriteLine($"Digite Informe o ano do seu nascimento ");
float ano= float.Parse(Console.ReadLine());

if(dia <= 31 && mes <=12 && ano <=2013)
{
    Console.WriteLine($"Sua data é valida");
    Console.WriteLine($"{dia}/{mes}/{ano}");
    
}

