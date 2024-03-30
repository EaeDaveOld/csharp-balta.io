using System;  // Importando uma biblioteca, já não se faz mais necessário importar o System, pois o .NET já faz isso por padrão.
namespace MeuApp  // Declarando o "package" - Divisão lógica.
{
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
        }
    }
}