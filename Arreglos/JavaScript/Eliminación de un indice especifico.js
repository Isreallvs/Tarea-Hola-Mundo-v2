const arr = [11, 21, 31, 41, 51, 61]
var position = 3
console.log("Antes de la eliminación el array es: ")
console.log(arr.join(", "))
//Eliminación del elemento en la posición especificada
arr.splice(position, 1)
console.log("\nDespués de la eliminación el array es: ")  
console.log(arr.join(", "))