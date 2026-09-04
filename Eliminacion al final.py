# Programa para eliminar un elemento al principio de un array
inputArr = [11, 21, 31, 41, 51, 61]
print("Antes de la eliminación, el array es:")
for j in range(len(inputArr)):
    print(inputArr[j], end=' ')
# Eliminando el último elemento del inputArr
inputArr.pop(-1)
print("\nDespués de la eliminación, el array es:")
for j in range(len(inputArr)):
    print(inputArr[j], end=' ')