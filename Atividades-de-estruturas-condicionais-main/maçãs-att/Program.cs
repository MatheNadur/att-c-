

Console.WriteLine($"Quantas maçãs você vai comprar: ");
int macas = int.Parse(Console.ReadLine());

if(macas>=12)
{
    float pagar = macas*0.25f;
Console.WriteLine($"Valor a pagar:{pagar}");
}
else
{
    float pagar = macas*0.30f;
Console.WriteLine($"Valor a pagar:{pagar}");
}

