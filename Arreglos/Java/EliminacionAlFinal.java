package Arreglos.Java;
public class EliminacionAlFinal {
    public static void main(String[] args) {
        int[] inputArr = {11, 21, 31, 41, 51, 61};

        System.out.println("Antes de la eliminación, el array es:");
        for (int j = 0; j < inputArr.length; j++) {
            System.out.print(inputArr[j] + " ");
        }

        int[] nuevoArr = new int[5];
        for (int j = 0; j < nuevoArr.length; j++){
            nuevoArr[j] = inputArr[j];

        }

        System.out.println("\nDespués de la eliminación, el array es: ");
        for (int j = 0; j < nuevoArr.length; j++) {
            System.out.print(nuevoArr[j] + " ");
        }
    }
}
