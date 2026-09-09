
function findele(arr, s, targetele) {
    for (let j = 0; j < s; j++) {
        if (arr[j] == targetele) {
            return j;
        }
    }
    return -1;
}
if (typeof require !== 'undefined' && require.main === module) {
    let arr = [12, 34, 10, 6, 40, 89, 98, 57, 19, 69];
    let targetele = 40;
    let s = arr.length;
    let result = findele(arr, s, targetele);
    if (result !== -1) {
        console.log("El elemento se encuentra en la posicion: ", result);
    } else {
        console.log("El elemento no se encuentra en el array");
    }
}
