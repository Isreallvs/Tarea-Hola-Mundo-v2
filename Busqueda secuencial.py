def findEle (inputArr, s, targetEle):
    for j in range(s):
        if (inputArr[j] == targetEle): #Aplicando busqueda lineal
            return j #Element encontrado en el indice j
    #No se encuentra el elemento objetivo
    return -1
if __name__ == "__main__":
    inputArr = [12, 34, 10, 6, 40, 89, 98, 57, 19, 69]
    targetEle = 40
    s = len(inputArr)
    #Operacion de busqueda
    idx = findEle(inputArr, s, targetEle)
    if idx != -1:
        print("El elemento se encuentra en la posicion: " + str(idx +1))
    else:
        print("No se encuentra el elemento.")
    