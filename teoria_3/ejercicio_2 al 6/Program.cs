/*2) Implementar un método para imprimir por consola todos los elementos de una matriz (arreglo de dos
dimensiones) pasada como parámetro. Debe imprimir todos los elementos de una fila en la misma línea
en la consola.

void ImprimirMatriz(double[,] matriz)

3) Implementar el método ImprimirMatrizConFormato, similar al anterior pero ahora con un
parámetro más que representa la plantilla de formato que debe aplicarse a los números al imprimirse.
La plantilla de formato es un string de acuerdo a las convenciones de formato compuesto, por ejemplo
“0.0” implica escribir los valores reales con un dígito para la parte decimal.

void ImprimirMatrizConFormato(double[,] matriz, string formatString)

4) Implementar los métodos GetDiagonalPrincipal y GetDiagonalSecundaria que devuelven
un vector con la diagonal correspondiente de la matriz pasada como parámetro. Si la matriz no es
cuadrada generar una excepción ArgumentException.

double[] GetDiagonalPrincipal(double[,] matriz)
double[] GetDiagonalSecundaria(double[,] matriz)

5) Implementar un método que devuelva un arreglo de arreglos con los mismos elementos que la matriz
pasada como parámetro:

double[][] GetArregloDeArreglo(double [,] matriz)

6) Implementar los siguientes métodos que devuelvan la suma, resta y multiplicación de matrices
pasadas como parámetros. Para el caso de la suma y la resta, las matrices deben ser del mismo tamaño,
en caso de no serlo devolver null. Para el caso de la multiplicación la cantidad de columnas de A debe
ser igual a la cantidad de filas de B, en caso contrario generar una excepción ArgumentException.

double[,]? Suma(double[,] A, double[,] B)
double[,] Multiplicacion(double[,] A, double[,] B)
*/
using System.Numerics;

double[,] matriz =
{
    {1.2, 2.4, 2.5},
    {5.1, 6, 9.3},
    {7.3, 9.5, 4}
};
void ImprimirMatriz(double[,] matriz)
{
    for(int i = 0; i < matriz.GetLength(0); i++)
    {
        for(int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write(matriz[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void ImprimirMatrizConFormato(double[,] matriz, string formatString)
{
     for(int i = 0; i < matriz.GetLength(0); i++)
    {
        for(int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write(matriz[i,j].ToString(formatString) + " ");
        }
        Console.WriteLine();
    }
}
double[] GetDiagonalPrincipal(double[,] matriz)
{
    if(matriz.GetLength(0) != matriz.GetLength(1))
    {
        throw new ArgumentException("la matriz debe ser cuadrada");
    }
    double[] v= new double[matriz.GetLength(0)];

    for(int i = 0; i < matriz.GetLength(0); i++)
    {
        v[i] = matriz[i,i];
    }
    return v;
}
double[] GetDiagonalSecundaria(double[,] matriz)
{
    if(matriz.GetLength(0) != matriz.GetLength(1))
    {
        throw new ArgumentException("la matriz debe ser cuadrada");
    }
    double[] v= new double[matriz.GetLength(1)];
    for(int i = 0; i < matriz.GetLength(1); i++)
    {
        v[i] = matriz[i,(matriz.GetLength(1) - 1) - i];
    }
    return v;
}

double[][] GetArregloDeArreglo(double [,] matriz)
{
    double[][] v = new double [matriz.GetLength(0)][];
    for(int i = 0; i < matriz.GetLength(0); i++)
    {
        v[i] = new double[matriz.GetLength(1)];
        for(int j = 0; j < matriz.GetLength(1); j++)
        {
            v[i][j] = matriz[i,j];
        }
    }
    return v;
}
double[,]? Suma(double[,] A, double[,] B)
{
    if(A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1))
    {
        return null;
    }
    int filas = A.GetLength(0);
    int col = A.GetLength(1);
    double[,] v = new double[filas,col];
    for(int i = 0; i < filas; i++)
    {
        for(int j = 0; j < col; j++)
        {
            v[filas,col] = A[filas,col] + B[filas,col];
        }
    }
    return v;
}
double[,] Multiplicacion(double[,] A, double[,] B)
{
    if(A.GetLength(1) != B.GetLength(0))
    {
        throw new ArgumentException("la cantidad de columnas de A debe ser igual a la cantidad de filas de B");
    }
    int filas = B.GetLength(0);
    int col = A.GetLength(1);
    double[,] v = new double[filas,col];
    
}
ImprimirMatriz(matriz);
ImprimirMatrizConFormato(matriz,"0.000");
double[] vp =  GetDiagonalPrincipal(matriz);
double[] vs =  GetDiagonalSecundaria(matriz);
foreach(double n in vp)
{
    Console.WriteLine(n);
}