Console.Write($"Qantas maças você deseja comprar ");
double maca= double.Parse(Console.ReadLine());

double menor= (maca * 0.30);
double maior= (maca * 0.25);

if ( maca < 12)
{
Console.WriteLine($"sua compra deu: {menor}R$ ");

}

else 
{
Console.WriteLine($"Sua compra deu: {maior}R$ ");

}
