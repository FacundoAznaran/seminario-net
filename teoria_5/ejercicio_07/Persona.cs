using System;

namespace ejercicio_07_08;

public class Persona
{
    public string Nombre {get;set;} = "";
    public char Sexo {get;set;}
    public int Dni {get;set;}
    public DateTime FechaDeNacimiento {get;set;}
    public int Edad => DateTime.Now.Year - FechaDeNacimiento.Year;

    public object this[int i]
    {
        get
        {
            return i switch
            {
                0 => Nombre,
                1 => Sexo,
                2 => Dni,
                3 => FechaDeNacimiento,
                4 => Edad,
                _ => throw new IndexOutOfRangeException($"no existe la propiedad para el indice {i}")
            };
        }
        set
        {
            switch (i)
            {
                case 0: Nombre = (string)value; break;
                case 1: Sexo = (char)value; break;
                case 2: Dni = (int)value;break;
                case 3: FechaDeNacimiento = (DateTime)value;break;
                default: break;
            }
        }
    }
}
