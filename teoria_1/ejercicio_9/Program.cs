Console.WriteLine("Ingrese las palabras:");
string st = Console.ReadLine();

bool simetria = true;

for(int i = 0; i < st.Length/2; i++)
{
    if(st[i] != st[st.Length - 1 - i])
    {
        simetria = false;
    }
}

Console.WriteLine(simetria);