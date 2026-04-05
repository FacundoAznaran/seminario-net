void Imprimir(params object[] vector)
{
    foreach(object item in vector)
    {
        Console.Write(item +" ");
    }
    Console.WriteLine("");
}

Imprimir(1, "casa", 'A', 3.4, DayOfWeek.Saturday);
Imprimir(1, 2, "tres");
Imprimir();
Imprimir("-------------");