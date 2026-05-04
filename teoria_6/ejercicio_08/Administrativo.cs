using System;

namespace ejercicio_08;

public class Administrativo(string nombre, int dni, DateTime fechadeingreso, double salariobase) :
Empleado(nombre,dni,fechadeingreso,salariobase)
{
    public double Premio {get;set;}
    public override double Salario => SalarioBase + Premio; 
    public override void AumentarSalario() => SalarioBase += SalarioBase * 0.01 * GetAntiguedad(); 
}
