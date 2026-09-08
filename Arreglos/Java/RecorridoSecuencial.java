package Arreglos.Java;
public class RecorridoSecuencial {
    public static void main (String[] args) {
        int[] arr = {40, 50, 60, 70 ,80, 90};

        System.out.print("Recorrido lineal (secuencial: ");
        System.out.print("\nLos elementos del array son: ");

        for (int idx : arr) {
            System.out.print(idx + " ");

        }
        System.out.println();
    }
}
