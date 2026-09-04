#Implementacion en python
def FindEle (arr, s, targetValue):
    l = 0
    h = s - 1
    while l <= h:
        mid = l +(h - l) // 2
        #Verificar si x esta presenta en mid
        if arr[mid] == targetValue:
            return mid
        #Si targetValue es mayor que el elemento mid, considerar la segunda mitad del array
        elif arr[mid] < targetValue:
            l = mid + 1
        #Si targetValue es menor que el elemento mid, considerar la primera mitad del array
        else:
            h = mid - 1
        #Si el control llega hasta aqui, significa que el elemento buscado no esta presente en el array
    return -1
if __name__ == "__main__":
    inputArr = [12, 34, 10, 6, 40, 89, 98, 57, 19, 69] #Arrays de entrada
    targetValue = 40 #Elemento objetivo a encontrar
    s = len(inputArr) #Tamaño del array
    #Operacion de busqueda
    idx = FindEle(inputArr, s, targetValue)
    if idx != -1:
        print("El elementos se encuentra en la posicion: " + str(idx + 1))
    else:
        print("El elemento no se encuentra")
