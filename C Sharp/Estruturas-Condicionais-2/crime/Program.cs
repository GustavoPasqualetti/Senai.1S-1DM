Console.WriteLine($"Voce telefonou para a vitima?");
string  telefone= Console.ReadLine();

Console.WriteLine($"Esteve no local do crime?");
string local= Console.ReadLine();

Console.WriteLine($"Voce mora perto da vitima?");
string mora= Console.ReadLine();

Console.WriteLine($"Voce devia para a vitima?");
string devia= Console.ReadLine();

Console.WriteLine($"Ja trabalhou com a vitima?");
string trabalhou= Console.ReadLine();

int contsim= 0;


if (telefone == "sim")
{
    contsim++;
}

if (local == "sim")
{
    contsim++;
}

if (mora == "sim")
{
    contsim++;
}

if (devia == "sim")
{
    contsim++;
}

if (trabalhou == "sim")
{
    contsim++;
}

if (contsim == 2)
{
Console.WriteLine($"voce e considerado suspeito");

}

if(contsim ==3 || contsim == 4 )
{
    Console.WriteLine($"voce e considerado cumplice");
    
}

if( contsim == 5)
{
    Console.WriteLine($"voce e considerado culpado");
    
}

else if (contsim == 1 || contsim == 0 )
{
Console.WriteLine($"voce e considerado inocente");

}