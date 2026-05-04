using System;

namespace ejercicio_08;

public abstract class Empleado(string nombre, int dni, DateTime fechadeingreso, double salarioBase)
{
    public string Nombre { get; } = nombre;
    public int Dni { get; } = dni;
    public DateTime FechaDeIngreso { get; } = fechadeingreso;
    public double SalarioBase { get; protected set; } = salarioBase;

    public abstract double Salario {get;}

    protected int GetAntiguedad() => (int)((DateTime.Parse("9/4/2022") - this.FechaDeIngreso).TotalDays /365.25);
    public abstract void AumentarSalario();

    public override string ToString()
    {
        return $"{GetType().Name} Nombre: {Nombre}, DNI: {Dni} Antigüedad: {GetAntiguedad()}\n" +
               $"Salario base: {SalarioBase}, Salario: {Salario}\n" +
               "-------------";
    }
}
