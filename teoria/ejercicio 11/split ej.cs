

Console.WriteLine("ingrese un texto");
string texto = Console.ReadLine();
string[] resultado = texto.Split(" ");
foreach (String x in resultado)
{
    Console.WriteLine(x);
}
