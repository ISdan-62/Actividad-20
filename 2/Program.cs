int cantidadNumeros;

Console.Write("Ingrese la cantidad de numeros: ");
cantidadNumeros = int.Parse(Console.ReadLine());

int[] arregloNumeros = new int[cantidadNumeros];

for (int i = 0; i < arregloNumeros.Length; i++)
{
    Console.Write("Ingrese el numero: ");
    arregloNumeros[i] = int.Parse(Console.ReadLine());
}

for (int i = cantidadNumeros - 1; i >= 0; i--)
{
    Console.Write($"{arregloNumeros[i]} ");
}