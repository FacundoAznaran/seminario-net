using System;

namespace Figuras;

public class Circulo(double radio)
{
    private double _radio = radio;

    public double GetArea() => Math.PI * Math.Pow(_radio,2);
}
