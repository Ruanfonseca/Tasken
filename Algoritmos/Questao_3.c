#include <stdio.h>

//linguagem C
int main()
{

    int numero, maior = -32767, menorImpar = 32767, soma = 0, contador = 1;
    int numeros[100] = {0};
    int ocorrencias[101] = {0}; // índices de 1 a 100 para representar os números

    do
    {
        printf("Digite um número (ou 0 para encerrar): ");
        scanf("%d", &numero);

        if (numero != 0)
        {
            numeros[contador++] = numero;

            // Item b) Encontra o maior número
            if (numero > maior)
                maior = numero;

            // Item c) Calcula a soma dos números para a média
            soma += numero;

            // Item d) Encontra o menor número ímpar
            if (numero % 2 != 0)
                menorImpar = numero;

            // Item e) Conta as ocorrências dos números
            ocorrencias[numero]++;
        }
    } while (numero != 0);

    // Item a) Quantidade de números lidos
    printf("Quantidade de números lidos: %d\n", contador);

    // Item b) Maior número
    printf("O maior número lido: %d\n", maior);

    // Item c) Média dos números
    printf("A média dos números lidos: %.2f\n", (float)soma / contador);

    // Item d) Menor número ímpar
    if (menorImpar != 32767)
        printf("O menor número ímpar lido: %d\n", menorImpar);
    else
        printf("Nenhum número ímpar foi lido.\n");

    // Item e) Ocorrências dos números
    for (int i = 0; i <= 100; i++)
    {
        if (ocorrencias[i] > 0)
            printf("O número %d ocorreu %d vezes.\n", i, ocorrencias[i]);
    }

    return 0;
}
