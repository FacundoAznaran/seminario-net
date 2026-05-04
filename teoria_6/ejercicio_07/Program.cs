Imprimidor.Imprimir(new A(), new B(), new C(), new D());
abstract class Instancia()
{
    public abstract void Imprimir();
}
class A: Instancia {
    public override void Imprimir() => Console.WriteLine("Soy una instancia A");
}
class B: Instancia {
    public override void Imprimir() => Console.WriteLine("Soy una instancia B");
}
class C: Instancia {
    public override void Imprimir() => Console.WriteLine("Soy una instancia C");
}
class D: Instancia {
    public override void Imprimir() => Console.WriteLine("Soy una instancia D");
}
static class Imprimidor
{
    public static void Imprimir(params Instancia[] vector)
    {
        foreach (Instancia o in vector)
        {
            o.Imprimir();
        }
    }
}