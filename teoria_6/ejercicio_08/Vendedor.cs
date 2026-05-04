using System;

namespace ejercicio_08;

public class Vendedor(string nombre, int dni, DateTime fechadeingreso, double salariobase) :
Empleado(nombre,dni,fechadeingreso,salariobase)
{
    public double Comision {get;set;}
    public override double Salario => SalarioBase + Comision;
    public override void AumentarSalario() => SalarioBase += (GetAntiguedad() >= 10) ? SalarioBase * 0.1 : SalarioBase * 0.05;
}
