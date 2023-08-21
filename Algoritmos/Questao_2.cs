using System;

namespace Questao2
{
    class Questao2
    {
        static void Main(string[] args)
        {
            string entrada = "jjjjooaoo";
            string comprimida = ComprimirString(entrada);
            Console.WriteLine("Resultado da função: " + comprimida);
        }

        static string ComprimirString(string entrada) {
            
            //se não for nula ou vazia
            if (string.IsNullOrEmpty(entrada))
                return entrada;

            int tamanho = entrada.Length;
            char caracterAtual = entrada[0];
            int contador = 1;
            
            //facilita a adição de caracteres
            var comprimidaBuilder = new System.Text.StringBuilder();

            // de um ate o tamanho da string 
            for (int i = 1; i < tamanho; i++)
            {
                //se for igual soma mais um no contador
                if (entrada[i] == caracterAtual)
                {
                    contador++;
                }
                else
                {
                    comprimidaBuilder.Append(caracterAtual);
                     
                     //verifica se o contador é maior do que um e adiciona ele no objeto de string
                    if (contador > 1)
                         comprimidaBuilder.Append(contador);

                    caracterAtual = entrada[i];
                    contador = 1;
                }
            }

            comprimidaBuilder.Append(caracterAtual);
            if (contador > 1)
                comprimidaBuilder.Append(contador);

            return comprimidaBuilder.ToString();
        }
    }
}
