using System;
using System.Linq;

namespace MegaSena
{
    internal class Program
    {

        enum Menu { Gerar = 1, Sair }

        static void Main(string[] args)
        {

            bool escolheuSair = false;

            while (!escolheuSair)
            {
                Console.WriteLine("Bem vindo(a) ao projeto Mega-Sena, desenvolvido por Renan Guedes. Escolha uma das opções:");
                Console.WriteLine("1 - Gerar uma nova sequência\n2 - Sair");

                Menu Opcao = (Menu)int.Parse(Console.ReadLine());

                switch (Opcao)
                {
                    case Menu.Gerar:
                        GeraNumero();
                        break;

                    case Menu.Sair:
                        escolheuSair = true;
                        break;

                    default:
                        break;
                }

                Console.Clear();
            }
        }

        static void GeraNumero()
        {
            int[] numeros = new int[6];
            Random random = new Random();
            int aleatorio;

            Console.WriteLine("---------------------");
            Console.WriteLine("A sequência gerada é:");

            for (int c = 0; c < 6; c++)
            {
                aleatorio = random.Next(1, 61);

                while (numeros.Contains(aleatorio))
                {
                    aleatorio = random.Next(1, 61);
                }

                numeros[c] = aleatorio;
            }

            // Ordenar o array em ordem crescente
            Array.Sort(numeros);

            // Exibir os números ordenados
            foreach (var numero in numeros)
            {
                Console.Write(numero + " ");
            }

            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("Pressione Enter para voltar ao Menu!");
            Console.ReadLine();
        }
    }
}