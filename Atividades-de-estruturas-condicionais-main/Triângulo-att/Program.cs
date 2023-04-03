Console.WriteLine($"Digite o valor do lado1 do triângulo: ");
float lado1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o valor do lado2 do triângulo: ");
float lado2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o valor do lado3 do triângulo: ");
float lado3 = float.Parse(Console.ReadLine());

if(lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine($"O triângulo informado é equilátero");
    
}
else if(lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
{
    Console.WriteLine($"O triângulo informado é isócele");

}
else
{
    Console.WriteLine($"O triângulo informado é escaleno");
    
}