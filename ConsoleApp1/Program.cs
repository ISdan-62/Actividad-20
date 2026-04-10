int cantidadNumeros;

Console.Write("Ingrese la cantidad de numeros: ");
cantidadNumeros = int.Parse(Console.ReadLine());

int[] arregloNumeros = new int[cantidadNumeros];

for (int i = 0; i < arregloNumeros.Length; i++)
{
    Console.Write("Ingrese el numero: ");
    arregloNumeros[i] = int.Parse(Console.ReadLine());
}

int numeroMayor = arregloNumeros[0];

for (int i = 1; i < arregloNumeros.Length; i++)
{
    if (arregloNumeros[i] > numeroMayor)
    {
        numeroMayor = arregloNumeros[i];
    }
}

Console.WriteLine($"El numero mayor es: {numeroMayor}");