

int fac(int x)
{
    for(int i = x-1; i > 1; i--)
    {
        x *= i;
    }
    if(x == 0)
    {
        return 1;
    }
    return x;
}

int facRecursivo(int x)
{
    int n = x;
    if(x > 1)
    {
        n *= facRecursivo(x-1);
    }
    return n;
}

int FacRecursivo(int x)
{
    // 1. Caso Base: Si x es 0 o 1, el resultado es 1
    if (x <= 1) 
    {
        return 1;
    }

    // 2. Caso Recursivo: El factorial de x es x multiplicado por el factorial de (x-1)
    return x * FacRecursivo(x - 1);
}

int facTernario(int x) => x <= 1 ? 1 : x * facTernario(x-1);

