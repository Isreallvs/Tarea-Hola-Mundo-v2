const arr = [11, 21, 31, 41, 51, 61]
var ele = 52
console.log("Antes de la inserción el array es: ")
for (i = 0; i < arr.length; i++) {
    console.log(arr.join(", "))
}
//Inserción del elemento al inicio del array
arr.unshift(ele)
console.log("\nDespués de la inserción el array es: ")  
for (i = 0; i < arr.length; i++) {
    console.log(arr.join(", "))
}