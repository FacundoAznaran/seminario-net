    
using System.Text;


// 1. Usando String convencional (Lento)
DateTime inicioString = DateTime.Now;
string texto = "";
for (int i = 0; i < 50000; i++)
{
    texto += "a"; 
}
DateTime finString = DateTime.Now;
TimeSpan diferenciaString = finString - inicioString;

// 2. Usando StringBuilder (Rápido)
DateTime inicioSB = DateTime.Now;
StringBuilder sb = new StringBuilder();
for (int i = 0; i < 50000; i++)
{
    sb.Append("a");
}
DateTime finSB = DateTime.Now;
TimeSpan diferenciaSB = finSB - inicioSB;

// Resultados
Console.WriteLine($"String tardó: {diferenciaString.TotalMilliseconds} ms");
Console.WriteLine($"StringBuilder tardó: {diferenciaSB.TotalMilliseconds} ms");