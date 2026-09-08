#include <iostream>
using namespace std;

int main()
{
    int inputArr[] = {11, 21, 31, 41, 51, 61};
    int n = sizeof(inputArr) / sizeof(inputArr[0]);
    int ele = 52;

    int nuevoArr[7]; //los arrays son de tamaño fijo entonces se hace otro array de un elemento mas grande

    cout << "Antes de la inserción, el array es: " << endl;
    for (int j = 0; j < n; j++)
    {
        cout << inputArr[j] << " ";
    }

    nuevoArr[0] = ele;
    for (int j = 0; j < n; j++)
    {
        nuevoArr[j + 1] = inputArr[j];
    }

    cout << "\nDespués de la inserción, el array es: " << endl;
    for (int j = 0; j < n + 1; j++)
    {
        cout << nuevoArr[j] << " ";
    }
    cout << endl;

    return 0;
}