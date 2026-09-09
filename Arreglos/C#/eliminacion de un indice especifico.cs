using System;

class program
{
    static void Main(string [] args)
    {
        int [] arr = {11, 21, 31, 41, 51, 61};
        int PosiEli = 3;
        
        Console.WriteLine("El array antes de la eliminación es: ");
        foreach (int elemento in arr)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();

        int [] nuevoArr = new int [arr.Length - 1];

        int j = 0;


        
        for(int i = 0; i < arr.Length; i++)
        {
            if (i != PosiEli)
            {
            nuevoArr[j] = arr[i];
            j++;
            }
        }

        Console.WriteLine("El array después de la eliminación es: ");
        foreach (int elemento in nuevoArr)
        {
            Console.Write(elemento + " ");
        }


    }
}