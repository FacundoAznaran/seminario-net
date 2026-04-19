using System;
using System.Security.Cryptography;

namespace ejercicio_01_03;

public class Persona(string nombre, int edad, int dni)
{
    private string _nombre = nombre;
    private int _edad = edad;
    private int _dni = dni;

    public void imprimir()
    {
        Console.WriteLine($"{_nombre}  {_edad}  {_dni}");
    }

    public string getNombre() => this._nombre;
    public bool esMayorQue(Persona p) => this._edad > p._edad;
}
