using System;
class program
{
    static int FindEle(int[] inputArr, int s, int targetEle)
    {
        for (int j = 0; j < s; j++)
        {
            if (inputArr[j] == targetEle) //Aplicando busqueda lineal
            {
                return j; // Elemento encontrado en el indice j
            }
        }
        //No se encuentra el elemento objetivo
        return -1;
    }

    static void Main(string[] args)
    {
        int[] inputArr = { 12, 34, 10, 6, 40, 89, 98, 57, 19, 69 };
        int targetEle = 40;
        int s = inputArr.Length;

        // Operacion de busqueda
        int idx = FindEle(inputArr, s, targetEle);

        if (idx != -1)
        {
            Console.WriteLine("El elemento se encuentra en la posicion: " + (idx + 1));
        }
        else
        {
            Console.WriteLine("No se encuentra el elemento.");
        }
    }
}