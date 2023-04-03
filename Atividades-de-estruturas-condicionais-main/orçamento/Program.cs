Console.WriteLine($"Informe seu salário: ");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe seu total de gastos:");
float gastos = float.Parse(Console.ReadLine());

if(gastos<=salario)
{
    Console.WriteLine($"Gastos dentro do orçamento");
    
}
else
{
    Console.WriteLine($"Orçamento estourado");
    
}

