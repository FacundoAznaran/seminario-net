/*
15) Contar Frecuencia de Palabras en Texto.
a) Crear un método ContarFrecuenciaPalabras que reciba una cadena de texto y devuelva un
diccionario con el conteo de cada palabra.
b) El conteo debe ser insensible a mayúsculas/minúsculas (tratar "Hola" y "hola" como iguales).
c) Dentro del método, procesar el texto para separar las palabras. Considerar usar texto.Split()
separando por espacios y signos de puntuación comunes.
d) Utilizar y devolver un Dictionary<string, int> donde la clave es la palabra y el valor su
frecuencia.
e) Probar el método: Llamarlo con un texto de ejemplo y mostrar en consola cada palabra y su
frecuencia del diccionario resultante.
Ejemplo de Salida Esperada (para "Hola, hola. Me escuchan? o no me escuchan?"):
hola: 2
me: 2
escuchan: 2
o: 1
no: 1
*/
Dictionary<string, int> contarFrecuencia(string s)
{
    Dictionary<string, int> contador = new Dictionary<string, int>();
    string[] texto = s.Split(new char[] {' ',',','.'}, StringSplitOptions.RemoveEmptyEntries);
    foreach(string p in texto)
    {
        string palabra = p.ToLower();
        if (!contador.ContainsKey(palabra))
        {
            contador[palabra] = 1;
        }
        else
        {
            contador[palabra]++;
        }
    }
    return contador;
}

Dictionary<string,int> diccionario = contarFrecuencia("Hola, hola. Me escuchan? o no me escuchan?");
foreach(var par in diccionario)
{
    Console.WriteLine($"{par.Key}: {par.Value}");
}