double total = 0;
string s;
do
{
    Console.WriteLine("ingrese el numero a sumar: ");
    s = Console.ReadLine();
    if(s != "")
    {
       try
        {
            total += double.Parse(s); 
            Console.WriteLine($"suma total: {total}");
        }
        catch
        {
            Console.WriteLine("debe ingresar un numero valido");
        }  
    }
    
} while(s != "");