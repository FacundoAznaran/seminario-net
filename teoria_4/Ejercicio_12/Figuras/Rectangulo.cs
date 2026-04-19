using System;

namespace Figuras;

public class Rectangulo(double Base, double altura)
{
    private double _base = Base;
    private double _altura = altura;

    public double GetArea() => _base * _altura;
}
