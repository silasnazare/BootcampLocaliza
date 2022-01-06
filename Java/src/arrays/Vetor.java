package arrays;
public class Vetor {
    public static void main(String[] args) throws Exception {
        int numeros[] = {39, 45, 54, 55};

        for (int i = 0; i <= numeros.length - 1; i++) {
            if (i < numeros.length - 1) {
                System.out.print(numeros[i] + ", ");
            }
            else {
                System.out.println(numeros[i] + ".");
            }
        }

        int vetor[] = {1, 3, 5, 7, 9};
        int numero = 2;
        boolean achou = false;

        for (int i = 0; i < vetor.length; i++) {
            if (vetor[i] == numero) {
                System.out.println("Número " + numero + " encontrado na posição: " + i + ".");
                achou = true;
            }
        }
        if (!achou) {
            System.out.println("Número " + numero + " não encontrado no vetor."); 
        }
    }
}
