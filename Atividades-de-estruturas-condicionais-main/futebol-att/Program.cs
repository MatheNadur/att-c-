Console.WriteLine($"Insira quantos gols o primeiro time fez:");
int time1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira quantos gols o segundo time fez:");
int time2 = int.Parse(Console.ReadLine());

if(time1 > time2)
{
    Console.WriteLine($"Vitória do primeiro time!");
}

else if(time2 > time1)
{
    Console.WriteLine($"Vitória do segundo time!");
}
else
{
 Console.WriteLine($"Empate!"); 
}
