Console.WriteLine($"Qual é a frequência do aluno");
float frequencia= float.Parse(Console.ReadLine());

Console.WriteLine($"Qual e a media do aluno");
float media= float.Parse(Console.ReadLine());


if (frequencia < 75 ) 
{
Console.WriteLine($"voce esta reprovado");

}

else if ( media >= 7 )
{
Console.WriteLine($"voce esta aprovado");

}
else if (media < 3)
{
 Console.WriteLine($"voce esta reprovado");
 
}
else 
{
Console.WriteLine($"voce tem direito a uma prova de recuperacao");

}

