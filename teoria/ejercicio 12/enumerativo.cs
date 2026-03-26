

for(meses m = meses.diciembre; m >= meses.enero; m--)
{
    Console.WriteLine(m);
}

Console.WriteLine("ingrese el mes a buscar");
string txt = Console.ReadLine();

for(meses m = meses.enero; m <= meses.diciembre; m++)
{
    if(txt == m.ToString())
    {
        Console.WriteLine("el texto corresponde a un mes");
        break;
    }
    else
    {
        Console.WriteLine(m);
    }

}
enum meses
{
    enero, febrero, marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre
}