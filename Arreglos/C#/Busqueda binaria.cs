using System;

class Program
{
    static int FindEle(int[] arr, int s, int targetValue)
    {
        int l = 0;
        int h = s - 1;

        while (l <= h)
        {
            int mid = l + (h - l) / 2;

            
            if (arr[mid] == targetValue)
            {
                return mid;
            }
            
            else if (arr[mid] < targetValue)
            {
                l = mid + 1;
            }
            
            else
            {
                h = mid - 1;
            }
        }
        
        return -1;
    }

    static void Main(string[] args)
    {
        int[] inputArr = { 12, 34, 10, 6, 40, 89, 98, 57, 19, 69 }; 
        int targetValue = 40; 
        int s = inputArr.Length; 

        
        int idx = FindEle(inputArr, s, targetValue);

        if (idx != -1)
        {
            Console.WriteLine("El elemento se encuentra en la posicion: " + (idx + 1));
        }
        else
        {
            Console.WriteLine("El elemento no se encuentra");
        }
    }
}