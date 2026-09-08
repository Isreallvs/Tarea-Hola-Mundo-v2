package Arreglos.Java;
public class EliminacionIndice {
    public static void main(String[] args) {
        int[] inputArr = {11, 21, 31, 41, 51, 61};
        int position = 3;

        System.out.println("Antes de la eliminación, el array es: ");
        for (int j = 0; j < inputArr.length; j++) {
            System.out.print(inputArr[j] + " ");
        }

        int[] nuevoArr = new int[5];
        int k = 0;
        for (int j = 0; j<inputArr.length; j++) {
            if (j != position) {
                nuevoArr[k] = inputArr[j];
                k++;
            }
        }

        System.out.println("\nDespués de la eliminación, el array es: ");
        for (int j = 0; j < nuevoArr.length; j++) {
            System.out.print(nuevoArr[j] + " ");
        }
    }
}        