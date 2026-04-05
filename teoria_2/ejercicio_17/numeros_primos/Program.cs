

bool esPrimo(int x)
{
    for (int i = 2; i <= Math.Sqrt(x); i++)
    {
        if(x % i == 0)
        {
            return false;
        }
    }
    return true;
}

int n = int.Parse(args[0]);
Console.WriteLine($"numeros primos entre 1 y {n}");

for(int i = 2; i < n; i++)
{
    if (esPrimo(i))
    {
        Console.WriteLine(i);
    }
}