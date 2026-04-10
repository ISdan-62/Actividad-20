int cantidadNumeros;

Console.Write("Ingrese la cantidad de numeros: ");
cantidadNumeros = int.Parse(Console.ReadLine());

int[] arregloNumeros = new int[cantidadNumeros];

for (int i = 0; i < arregloNumeros.Length; i++)
{
    Console.Write("Ingrese el numero: ");
    arregloNumeros[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < arregloNumeros.Length - 1; i++)
{
    for (int j = i + 1; j < arregloNumeros.Length; j++)
    {
        if (arregloNumeros[i] > arregloNumeros[j])
        {
            int temp = arregloNumeros[i];
            arregloNumeros[i] = arregloNumeros[j];
            arregloNumeros[j] = temp;
        }
    }
}

Console.WriteLine("Numeros ordenados:");
for (int i = 0; i < arregloNumeros.Length; i++)
{
    Console.Write(arregloNumeros[i] + " ");
}