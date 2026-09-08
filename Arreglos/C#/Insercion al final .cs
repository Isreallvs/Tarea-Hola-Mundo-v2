using System;
class program
{
    static void Main(string [] args)
    {
        int [] arr = {11, 21, 31, 41, 51, 61};
        
        //El arreglo antes de la inserción
        Console.WriteLine("Antes de la inserción el array es: ");

        foreach (int elemento in arr)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();

        
        int ele = 52;
        
        //Hacemos un nuevo array
        int [] nuevoArr = new int[arr.Length + 1];
        

        for (int i = 0; i < arr.Length; i++)
        {
            nuevoArr[i] = arr[i];
        }
        //Se mueve a la ultima posicion
        nuevoArr[arr.Length] = ele;

        //El arreglo despues de la inserción
        Console.WriteLine("El array despues de la inserción es: ");
        foreach (int elemento in nuevoArr)
        {
            Console.Write(elemento + " ");
        }
    }
}