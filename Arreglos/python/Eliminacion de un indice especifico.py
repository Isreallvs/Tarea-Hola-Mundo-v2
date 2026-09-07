# Programa para eliminar un elemento en un indice especifico 
inputArr = [11, 21, 31, 41, 51, 61]
position = 3 # Indice desde el que se realizará la eliminación
 
print("Antes de la eliminación, el array es: ") 
for j in range(len(inputArr)): 
    print(inputArr[j], end=" ")

# Eliminacion del elemento en el tercer indice del inputArr[position]
del inputArr[position]

print("\nDespues de la eliminación, el array es: ")
for j in range(len(inputArr)): 
    print(inputArr[j], end=" ")