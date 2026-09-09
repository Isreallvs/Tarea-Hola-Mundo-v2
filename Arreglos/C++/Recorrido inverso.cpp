#include <iostream>
using namespace std;

int main()
{
    int arr[] = {40, 50, 60, 70, 80, 90};
    int n = sizeof(arr) / sizeof(arr[0]);

    cout << "Recorrido inverso del array: ";
    cout << "\nLos elementos del array son: ";

    for (int idx = n - 1; idx >= 0; idx--)
    {
        cout << arr[idx] << " ";
    }
    cout << endl;

    return 0;
}