package arrays;
import java.util.Random;

public class Matriz {
    public static void main(String[] args) {
        Random random = new Random();
        int tamanho = 5;
        int matriz[][];
        matriz = new int[tamanho][tamanho];

        for (int i = 0; i < tamanho; i++) {
            for (int j = 0; j < tamanho; j++) {
                matriz[i][j] = random.nextInt(0, 9);
                System.out.print("[" + matriz[i][j] + "]");
            }
            System.out.println();
        }

        String nome[] = {"André", "Thiago", "Bruno", "Carlos", "Cássio"};
        double altura[] = {1.71, 1.78, 1.75, 1.87, 1.71};

        for (int i =  0; i <= 4; i++) {
            System.out.println(nome[i] + ", " + altura[i] + ".");
        }
    }
}
