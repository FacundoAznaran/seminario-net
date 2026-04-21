using System;

namespace ejercicio_07_08;

public class ListaPersonas
{
    private List<Persona> _lista = [];
    public void Agregar(Persona p)
    {
        _lista.Add(p);
    }

    public Persona? this[int dni]
    {
        get
        {
            foreach(Persona p in _lista)
            {
                if(p.Dni == dni)
                    return p;
            }
            return null;
        }
    }
    public List<string> this[char c]
    {
        get
        {
            List<string> lista = [];
            foreach(Persona p in _lista)
            {
                if(p.Nombre[0] == c)
                    lista.Add(p.Nombre);
            }
            return lista;
        }
    }
}
