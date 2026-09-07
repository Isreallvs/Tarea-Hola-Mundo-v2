using System;
using System.Linq.Expressions;
class program
{
    static void Main(string [] args)
    {
        int [] arr = {11, 21, 31, 41, 51, 61};
        
        //El arreglo antes de la inserción
        foreach (int elemento in arr)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();

        //Insertamos el elemento al inicio
        int ele = 52;
        
        //Hacemos un nuevo array
        int [] nuevoArr = new int[arr.Length + 1];
        nuevoArr [0] = ele;

        for (int i = 0; i < arr.Length; i++)
        {
            nuevoArr[i + 1] = arr[i];
        }

        //El arreglo despues de la inserción
        Console.WriteLine("El array despues de la inserción es: ");
        foreach (int elemento in nuevoArr)
        {
            Console.Write(elemento + " ");
        }
    }
}