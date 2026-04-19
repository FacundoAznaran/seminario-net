using System;

namespace ejercicio_6;

public class Ecuacion(double a, double b, double c)
{
    private readonly double _a = a;
    private double _b = b;
    private double _c = c;
    public double GetDiscriminante() => (Math.Pow(_b,2)-4*_a*_c);

    public int GetCantidadDeRaices() =>  GetDiscriminante() switch
    {
        //forma elegante de usar el switch para este caso
        < 0 => 0,
        0 => 1,
        _  => 2
    };

    public void ImprimirRaices()
    {
        double d = this.GetDiscriminante();
        switch (this.GetCantidadDeRaices()){
            case 0: 
                Console.WriteLine("la ecuacion no tiene solucion");
                break;
            case 1:
                double x = (-_b + Math.Sqrt(d))/ 2*_a;
                Console.WriteLine($"posee una raiz: {x}");
                break;
            case 2:
                double x1 = (-_b + Math.Sqrt(d))/ 2*_a;
                double x2 = (-_b - Math.Sqrt(d))/ 2*_a;
                Console.WriteLine($"la ecuacion posee 2 raices: x1= {x1} y x2= {x2}");
                break;
        }
    }
}
