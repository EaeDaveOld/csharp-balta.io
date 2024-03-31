using System;  // Importando uma biblioteca, já não se faz mais necessário importar o System, pois o .NET já faz isso por padrão.
namespace MeuApp  // Declarando o "package" - Divisão lógica
{
    /// <summary>
    /// Valor explicativo da minha classe
    /// </summary>
    class Program  // Declarando a classe
    {
        static void Main(string[] args)  // Método principal, onde é executado o programa por padrão
        {
            // Variáveis
            int idade;  // Correto, inicia com zero
            int anos = 22;  // Correto, inicia com 22
            var numero = 22;  // Correto, inicia com 22
            // var numero2;  // Errado
            // Console.WriteLine(idade);
            Console.WriteLine(anos);
            Console.WriteLine(numero);



            // Constantes
            // const int IDADE_MINIMA;  // Errado
            const int IDADE_MINIMA = 22;  // Correto, inicia com 22
            Console.WriteLine(IDADE_MINIMA);
            // const var IDADE_MAXIMA = 30; // Errado
            // const var IDADE_MAXIMA; // Errado



            // Palavras reservadas ou Keywords
            // var, char, int, float, double, const
            // Não pode declarar variáveis e constantes com os nomes reservados pelo sistema
            // int float = 23;  / Errado



            // Comentários
            // Comentário em uma linha
            /*
                Comentário em várias
                linhas
            */
            /// Notação XML (Metadata)



            // Tipos primitivos - built-in types
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



            /*
            Números Inteiros
            - short/ushort
            - int/uint
            - long/ulong
            - Assim como temos o signed nos bytes, nos números por padrão são permitidos valores negativos
            - Então usamos o unsigned para definir que o mesmo não pode receber valores negativos
            - O tipo int é o mais comum a ser encontrado

            Definições:
            - short (16bits)
            - -32.768 até 32.767

            - ushort (16bits)
            - 0 até 65.535

            - int (32bits)
            - -2.147.483.648 até 2.147.483.647

            - uint (32bits)
            - 0 até 4.294.967.295

            - long (64bits)
            - -9.223.372.036.854.775.808 até 9.223.372.036.854.775.807

            - ulong (64bits)
            - 0 até 18.446.744.073.709.551.615
            */



            /*
            Números Reais
            - float (Notação F)
            - double
            - decimal (Notação M)

            Definições:
            - float (32bits)
            - -3.402823e38 até 3.402823e38

            - double (64bits)
            - -1.79769313486232e308 até 1.79769313486232e308

            - decimal (128bits)
            - (+ ou -)1.0 x 10e-28 até 7.9 x 10e28

            - Números que exigem uma maior precisão, ou seja, com pontuação
            - Possuem assimilação negativa e positiva por padrão, dispensando uso do signed/unsigned em seus tipos
            */

            var salario = 2.500;  // O "var" vai dinamicamente atribuir um tipo double para a variável
            double salarioDesejado = 4.500;  // Para o tipo double, não se faz necessário especificar um sufixo
            float novoSalario = 3.000f;  // Para implicitamente declarar como float, deve-se atribuir o "f" ao final do número
            decimal salarioAnual = 36.000m;  // Para implicitamente declarar como decimal, deve-se atribuir o "m" ao final do número
        }
    }
}