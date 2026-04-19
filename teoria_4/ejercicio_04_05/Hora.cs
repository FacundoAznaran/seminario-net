using System;

namespace ejercicio_04_05;

public class Hora
{
    public int Horas {get;set;} 
    public int Min {get;set;} 
    public double Seg {get;set;}

    public Hora (int hora, int min, int seg)
    {
        Horas = hora;
        Min = min;
        Seg = seg;
    }

    public Hora(double n)
    {
        Horas = (int)n;
        n = (n - Horas) * 60;
        Min = (int)n;
        Seg = (n - Min) * 60;
    }
    public void Imprimir()
    {
        Console.WriteLine($"{Horas} horas, {Min} minutos y {Seg:0.000} segundos");
    }

}
