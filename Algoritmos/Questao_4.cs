using System;
using System.IO;
using System.Linq;
//Utilizando C#

namespace AnaliseArquivoTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho completo do arquivo de texto: ");
            string filePath = Console.ReadLine();

            if (File.Exists(filePath))
            {
                string[] linhas = File.ReadAllLines(filePath);

                int linhaMaisVogais = EncontrarLinhaMaisVogais(linhas);
                int linhaMaisConsoantes = EncontrarLinhaMaisConsoantes(linhas);

                Console.WriteLine($"Linha com mais vogais: {linhaMaisVogais + 1}");
                Console.WriteLine($"Linha com mais consoantes: {linhaMaisConsoantes + 1}");
            }
            else
            {
                Console.WriteLine("Arquivo não encontrado.");
            }
        }

        static int ContarVogais(string texto)
        {
            //verifica se o texto tem vogais e quantas são , algo parecido com um stream  
            return texto.Count(c => "AEIOUaeiou".Contains(c));
        }

        static int ContarConsoantes(string texto)
        {
            return texto.Count(c => char.IsLetter(c) && !"AEIOUaeiou".Contains(c));
        }

        static int EncontrarLinhaMaisVogais(string[] linhas)
        {
            int linhaMaisVogais = -1;
            int maiorContagemVogais = -1;

            for (int i = 0; i < linhas.Length; i++)
            {
                int contagemVogais = ContarVogais(linhas[i]);
                if (contagemVogais > maiorContagemVogais)
                {
                    maiorContagemVogais = contagemVogais;
                    linhaMaisVogais = i;
                }
            }

            return linhaMaisVogais;
        }

        static int EncontrarLinhaMaisConsoantes(string[] linhas)
        {
            int linhaMaisConsoantes = -1;
            int maiorContagemConsoantes = -1;

            for (int i = 0; i < linhas.Length; i++)
            {
                int contagemConsoantes = ContarConsoantes(linhas[i]);
                if (contagemConsoantes > maiorContagemConsoantes)
                {
                    maiorContagemConsoantes = contagemConsoantes;
                    linhaMaisConsoantes = i;
                }
            }

            return linhaMaisConsoantes;
        }
    }
}
