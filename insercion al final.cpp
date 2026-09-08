#include <iostream>
using namespace std;

int main()
{
    int inputArr[] = {11, 21, 31, 41, 51, 61};
    int n = sizeof(inputArr) / sizeof(inputArr[0]);
    int ele = 52;

    int nuevoArr[7];

    cout << "Antes de la inserción, el array es: " << endl;
    for (int j = 0; j < n; j++)
    {
        cout << inputArr[j] << " ";
    }

    for (int j = 0; j < n; j++)
    {
        nuevoArr[j] = inputArr[j];
    }
    nuevoArr[n] = ele;

    cout << "\nDespués de la inserción, el array es: " << endl;
    for (int j = 0; j < n + 1; j++)
    {
        cout << nuevoArr[j] << " ";
    }
    cout << endl;

    return 0;
}