int dividendo,  divisor, quociente, resto;

Console.Clear();

Console.WriteLine("Máximo Divisor Comum (método iterativo)");

Console.WriteLine();

Console.WriteLine("Digite o dividendo:");
dividendo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o divisor:");
divisor = Convert.ToInt32(Console.ReadLine());

resto = dividendo % divisor;

while (resto == 0)
quociente = dividendo / divisor;
resto = dividendo % divisor;

if (resto == 0)
{
    Console.WriteLine($"MDC(a, b) = {dividendo}");
}
else
{
    dividendo =  divisor;
    divisor = resto;
    resto = dividendo % divisor;
    Console.WriteLine($"MDC(a, b) = {resto}");
}