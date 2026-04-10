int cantidadNumeros;

Console.Write("Ingrese la cantidad de numeros: ");
cantidadNumeros = int.Parse(Console.ReadLine());

int[] arregloNumeros = new int[cantidadNumeros];

for (int i = 0; i < arregloNumeros.Length; i++)
{
    Console.Write("Ingrese el numero: ");
    arregloNumeros[i] = int.Parse(Console.ReadLine());
}
Console.Write("Ingrese la posicion: ");
int posicion = int.Parse(Console.ReadLine());

Console.Write("Ingrese el nuevo valor: ");
int nuevo = int.Parse(Console.ReadLine());

arregloNumeros[posicion] = nuevo;

Console.WriteLine("Arreglo actualizado:");
for (int i = 0; i < arregloNumeros.Length; i++)
{
    Console.Write(arregloNumeros[i] + " ");
}