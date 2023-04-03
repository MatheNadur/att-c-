int senha = 1234;

Console.WriteLine($"Digite a senha de acesso: ");
int acesso = int.Parse(Console.ReadLine());


if(acesso == senha)
{
    Console.WriteLine($"Acesso permitido!");
    
}
else
{
    Console.WriteLine($"Acesso negado!");
    
}
