#include <iostream>
using namespace std;

int FindEle(int arr[], int s, int targetValue)
{
    int l = 0;
    int h = s - 1;

    while (l <= h)
    {
        int mid = l + (h - 1 ) / 2;

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

int main ()
{
    int inputArr[] = {12, 34, 10, 6, 40, 89, 98, 57, 19, 69};
    int targetValue = 40;
    int s = sizeof(inputArr) / sizeof(inputArr[0]);

    int idx = FindEle(inputArr, s, targetValue);

    if (idx != -1)
    {
        cout << "El elemento se encuentra en la posicion: " << (idx + 1) << endl;
    }
    else
    {
        cout << "El elemento no se encuentra" << endl;
    }

    return 0;
}