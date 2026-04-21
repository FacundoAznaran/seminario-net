using System;

namespace ejercicio_12;

public class Libro
{
    public string ISBN {get;}
    public DateTime? FechaDePublicacion {get;init;}
    public required string Titulo {get;init;}
    public double Precio {get;set;}

    public Libro(string ISBN)
    {
        this.ISBN = ISBN;
    }
}
