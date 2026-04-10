int cantidadNumeros;
int suma = 0;

Console.Write("Ingrese la cantidad de numeros: ");
cantidadNumeros = int.Parse(Console.ReadLine());

int[] arregloNumeros = new int[cantidadNumeros];

for (int i = 0; i < arregloNumeros.Length; i++)
{
    Console.Write("Ingrese el numero: ");
    arregloNumeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < arregloNumeros.Length; i++)
{
    suma += arregloNumeros[i];
}

double promedio = (double)suma / arregloNumeros.Length;
Console.WriteLine("El promedio es: " + promedio);