
void factorial(int n, out int f)
{
    for(int i = n - 1; i> 1; i--)
    {
        n *= i;
    }   
    f = n;
}

void FacRecursivo(int n, out int f)
{
    if (n <= 1) 
    {
        f = 1; // Caso base: asignamos el "freno"
    }
    else 
    {
        // No podemos hacer: f = n * FacRecursivo(n-1, out f) <-- ERROR
        
        int resultadoTemporal; 
        FacRecursivo(n - 1, out resultadoTemporal); // Llamada recursiva
        
        f = n * resultadoTemporal; // Recién aquí asignamos f
    }
}
int f;
int n = 10;
factorial(n, out f);
Console.WriteLine(f);