function Findele (arr, s, targetvalue) {
    let start = 0;
    let end = s - 1;
    while (start <= end) {
        let mid = Math.floor((start + end) / 2);
        if (arr[mid] === targetvalue) { //verificar si x esta presente en el medio
            return mid;
        } else if (arr[mid] < targetvalue) { //si x es mayor, tomar la mitad derecha
            start = mid + 1;
        } else { // si x es menor, tomar la mitad izquierda
            end = mid - 1;
        }
    }
    return -1; // si x no esta presente en el array
}

if (typeof require !== 'undefined' && require.main === module) {
    let arr = [12, 34, 10, 6, 40, 89, 98, 57, 19, 69];
    let targetvalue = 69;
    let s = arr.length;
    let result = Findele(arr, s, targetvalue);
    if (result !== -1) {
        console.log("El elemento se encuentra en la posicion: ", result);
    } else {
        console.log("El elemento no se encuentra en el array");
    }       
}