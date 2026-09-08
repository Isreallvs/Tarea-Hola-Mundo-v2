using System;
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

        int []nuevoArr = new int[arr.Length - 1];

        for (int i = 1; i < arr.Length; i++)
        {
            nuevoArr[i - 1] = arr[i];

        }

        Console.WriteLine("Después de la eliminación el array es: ");
        foreach (int elemento in nuevoArr)
        {
            Console.Write(elemento + " ");
        }


    }
}