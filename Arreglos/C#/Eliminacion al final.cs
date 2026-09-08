using System;
using System.Globalization;
class program
{
    static void Main(string [] args)
    {
        int [] arr = {11, 21, 31, 41, 51, 61};
        
        Console.WriteLine("El array antes de la eliminación es: ");
        foreach (int elemento in arr)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();

        int [] nuevoArr = new int [arr.Length - 1];

        for(int i = 0; i < nuevoArr.Length; i++)
        {
            nuevoArr[i] = arr[i];
        }

        Console.WriteLine("El array después de la eliminación es: ");
        foreach (int elemento in nuevoArr)
        {
            Console.Write(elemento + " ");
        }

    }
}