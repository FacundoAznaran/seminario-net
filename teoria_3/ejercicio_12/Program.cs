bool Balanceado(string e)
{
    Stack<char> pila = new Stack<char>();
    
    foreach(char c in e)
    {
        if(c == '(')
        {
            pila.Push(c);
        }
        else if(c == ')')
        {
            if(pila.Count == 0)
            {
                return false;
            }
            pila.Pop();
        }
    }
    return pila.Count == 0;
}
Console.WriteLine(Balanceado("(2+2)*5)"));