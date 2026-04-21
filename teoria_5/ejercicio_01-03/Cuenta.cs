using System;
using System.Diagnostics.CodeAnalysis;

namespace ejercicio_01_03;

public class Cuenta
{
    public double Saldo{get;set;}
    public int Id{get;set;}
    private static int s_id = 0;
    private static int s_depositos = 0;
    private static int s_extracciones = 0;
    private static double s_totalD = 0;
    private static double s_totalE = 0;
    private static double s_saldo = 0;
    private static int s_denegado = 0;
    public static List<Cuenta> Cuentas{get;} = [];

    public Cuenta()
    {
        Id = ++Cuenta.s_id;
        Cuenta.Cuentas.Add(this);
        Console.WriteLine($"se creo la cuenta ID: {Cuenta.s_id}");
    }


    public Cuenta Extraer(double monto)
    {
        if(Saldo >= monto)
        {
            Saldo -= monto;
            Cuenta.s_extracciones++;
            Cuenta.s_totalE += monto;
            Cuenta.s_saldo -= monto;
            Console.WriteLine($"se extrajo {monto} en la cuenta {Id} (Saldo = {Saldo})");
        }
        else
        {
            Console.WriteLine("saldo insuficiente");
            Cuenta.s_denegado++;
        }
        return this;
    }
    public Cuenta Depositar(double monto)
    {
        if(monto > 0)
        {
            Saldo += monto;
            Cuenta.s_depositos++;
            Cuenta.s_totalD += monto;
            Cuenta.s_saldo += monto;
            Console.WriteLine($"se deposito {monto} en la cuenta {Id} (Saldo = {Saldo})");
        }
        else
            Console.WriteLine("monto ingresado invalido");
        return this;
    }

    public static List<Cuenta> GetCuentas() => Cuentas.ToList(); 
    public static void ImprimirDetalle()
    {
        Console.WriteLine($@"CUENTAS CREADAS: {Cuenta.s_id}
DEPOSITOS: {Cuenta.s_depositos} -total depositado: {Cuenta.s_totalD}
EXTRACCIONES: {Cuenta.s_extracciones} - total extraido: {Cuenta.s_totalE}
-saldo {Cuenta.s_saldo}
*se denegaron {Cuenta.s_denegado} extracciones por falta de fondos");
    }
}
