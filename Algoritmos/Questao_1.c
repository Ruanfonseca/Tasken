#include <stdio.h>
#include <stdlib.h>
//Utilizando C

int eh_quadrado_perfeito(int num) {
    int sqrt_num = 0;
    while (sqrt_num * sqrt_num < num) {
        sqrt_num++;
    }
    return sqrt_num * sqrt_num == num;
}

int* apagaItem(int* lista, int tamanho) {
    int* novaLista = malloc((tamanho - 1) * sizeof(int));
    for (int i = 0; i < tamanho - 1; i++) {
        novaLista[i] = lista[i + 1];
    }
    free(lista);
    return novaLista;
}

void exibiLista(int* lista, int tamanho) {
    for (int i = 0; i < tamanho; i++) {
        printf(" %d ", lista[i]);
    }
    printf("\n");
}

int main() {
    int quantidade;
    printf("Informe um Número: \n ");
    scanf("%d", &quantidade);

    int *quadrados_perfeitos = malloc(quantidade * sizeof(int));
    if (quadrados_perfeitos == NULL) {
        printf("Erro ao alocar memória.\n");
        return 1;
    }

    int contador = 0;
    int num = 100;

    while (contador < quantidade && num >= 1) {
        if (eh_quadrado_perfeito(num)) {
            quadrados_perfeitos[contador] = num;
            contador++;
        }
        num--;
    }

    puts(" \n");
    
    exibiLista(quadrados_perfeitos, contador);
    for (int i = 0; i < contador - 1; i++) {
        quadrados_perfeitos = apagaItem(quadrados_perfeitos, contador - i);
        exibiLista(quadrados_perfeitos, contador - i - 1);
    }
    
    free(quadrados_perfeitos);

    return 0;
}
