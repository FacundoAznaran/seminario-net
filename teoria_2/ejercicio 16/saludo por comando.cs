for(int i = 0; i < args.Length; i++)
{
    Console.WriteLine($"hola {args[i]}");
}

foreach(string x in args)
{
    Console.WriteLine($"hola {x}");
}