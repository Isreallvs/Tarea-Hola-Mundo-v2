package Arreglos.Java;
public class BusquedaBinaria {
    public static int FindEle(int[] arr, int s, int targetValue){
        int l = 0;
        int h = s -1;

        while (1 <= h){
            int mid = l + (h - l) / 2;

            if (arr[mid] == targetValue) {
                return mid;

            } else if (arr[mid] < targetValue) {
                l = mid + 1;
            } else {
                h = mid - 1;
            }

        }
        return -1;

    }
    public static void main(String[] args) {
        int[] inputArr = {12, 34, 10, 6, 40, 89, 98, 57, 19, 69};
        int targetValue = 40;
        int s = inputArr.length;

        int idx = FindEle(inputArr, s, targetValue);

        if (idx != -1) {
            System.out.println("El elemento se encuentra en la posición: " + (idx + 1));
        } else{
            System.out.println("El elemento no se encuentra.");
        }
    }    
}
