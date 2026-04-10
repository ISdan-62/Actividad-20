int cantidadNumeros;
int numerosImpares = 0;

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
    if (arregloNumeros[i] % 2 != 0)
    {
        numerosImpares++;
    }
}

Console.WriteLine($"Cantidad de numeros impares: {numerosImpares}");