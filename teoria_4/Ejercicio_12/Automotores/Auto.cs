using System;

namespace Automotores;

public class Auto(string marca, int modelo)
{
    private string _marca = marca;
    private int _modelo = modelo;

    public Auto(string marca) : this(marca,DateTime.Now.Year){}
    public Auto() : this("Fiat",DateTime.Now.Year){}
    public string ObtenerDescripcion() => $"Auto {_modelo} {_marca}";
}
