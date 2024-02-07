Console.WriteLine($"Informe seu nome: ");
string nome = Console.ReadLine();

while (nome == "")
{
    Console.WriteLine($"Digite um nome com pelo menos 1 caracter");
    nome = Console.ReadLine();
}
Console.WriteLine($"Nome recebido com sucesso ");




Console.WriteLine($"Informe sua idade");
int idade = int.Parse(Console.ReadLine());

while (idade > 100)
{
    Console.WriteLine($"Digite uma idade válida");
    idade = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Idade registrada com sucesso");



Console.WriteLine($"Infome seu salário");
int salario = int.Parse(Console.ReadLine());

while (salario < 1)
{
    Console.WriteLine($"Digite um salário valido");
    salario = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Salário registrado com sucesso");



Console.WriteLine($"Informe seu estado civil: s(Solteiro(a))  c(Casado(a))  v(Viuvo(a))  d(Divorciado(a))");
string estadoCivil = Console.ReadLine();

while(estadoCivil != "s" && estadoCivil != "c" && estadoCivil != "v" && estadoCivil != "d" )
{
    Console.WriteLine($"Digite um estado civil válido");
    estadoCivil= Console.ReadLine();
}
Console.WriteLine($"Estado civil registrado");
estadoCivil = Console.ReadLine();

