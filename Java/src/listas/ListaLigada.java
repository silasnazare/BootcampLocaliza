package listas;

public class ListaLigada {
   ListaLigada inicio;
   ListaLigada proximo;
   int dado;

   public ListaLigada() {}

   public ListaLigada(int dado) {
       this.dado = dado;
   }

   void insere(int dado) {
       ListaLigada novoElemento = new ListaLigada(dado);
       this.inicio = novoElemento;
       this.proximo = inicio;
    }
}
