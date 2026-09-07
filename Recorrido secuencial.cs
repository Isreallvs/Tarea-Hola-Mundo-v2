using System;
class program
{
    static void Main(string [] args)
    {
        int [] arr = {40, 50, 60, 70, 80, 90};
        Console.WriteLine("Recorrido lineal (secuencial): ");
        Console.WriteLine("Los elementos del array son: ");

        foreach (int elemento in arr)
        {
            Console.Write(elemento + " ");
        }
    }
}