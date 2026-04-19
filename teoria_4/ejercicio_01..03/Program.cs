using ejercicio_01_03; 
List<Persona> lista = new List<Persona>();

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("ingrese nombre,edad, y dni");
    string nombre = Console.ReadLine();
    int edad = int.Parse(Console.ReadLine());
    int dni = int.Parse(Console.ReadLine());
    Persona p = new Persona(nombre,edad,dni);
    lista.Add(p);
}
Persona chica = lista[0];
foreach(Persona p in lista)
{
    p.imprimir();
    if(chica.esMayorQue(p))
        chica = p;
}
Console.WriteLine($"la persona mas joven es: {chica.getNombre()}");
