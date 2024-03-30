using System;  // Importando uma biblioteca, já não se faz mais necessário importar o System, pois o .NET já faz isso por padrão.
namespace MeuApp  // Declarando o "package" - Divisão lógica.
{
    /// <summary>
    /// Valor explicativo da minha classe.
    /// </summary>
    class Program  // Declarando a classe.
    {
        static void Main(string[] args)  // Método principal, onde é executado o programa por padrão.
        {
            // Variáveis.
            int idade;  // Correto, inicia com zero.
            int anos = 22;  // Correto, inicia com 22.
            var numero = 22;  // Correto, inicia com 22.
            // var numero2;  // Errado.
            // Console.WriteLine(idade);
            Console.WriteLine(anos);
            Console.WriteLine(numero);



            // Constantes.
            // const int IDADE_MINIMA;  // Errado.
            const int IDADE_MINIMA = 22;  // Correto, inicia com 22.
            Console.WriteLine(IDADE_MINIMA);
            // const var IDADE_MAXIMA = 30; // Errado.
            // const var IDADE_MAXIMA; // Errado.



            // Palavras reservadas ou Keywords.
            // var, char, int, float, double, const.
            // Não pode declarar variáveis e constantes com os nomes reservados pelo sistema
            // int float = 23;  / Errado.



            // Comentários.
            // Comentário em uma linha
            /*
                Comentário em várias
                linhas
            */
            /// Notação XML (Metadata)



            // Tipos primitivos - built-in types.
            /*
            - Simple Types (Tipos Simples)
            - Enums (Enumeradores)
            - Structs (Estruturas)
            - Nullable Types (Tipos Nulos)
            */


            /* Tipo byte e sbyte
            - byte (8bits)
            - 0 até 255
            */
            byte byteMaximo = 255;

            /*
            - sbyte (8bits)
            - -128 até 127
            */
            sbyte byteMinimo = -128;
            
        }
    }
}