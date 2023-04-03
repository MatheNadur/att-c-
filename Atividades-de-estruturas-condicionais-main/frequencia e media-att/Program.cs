float media = 3.0f;
float frequencia = 0.75f*100;

 if(media >= 7 && frequencia >= 75)
{
    Console.WriteLine($"APROVADO!");  
}

else if(media>=3 && frequencia >= 75)
{
    Console.WriteLine($"Faça a recuperação!");   
}
else
{
    Console.WriteLine($"REPROVADO!");
}