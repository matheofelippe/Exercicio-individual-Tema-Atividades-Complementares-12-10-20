using System;
using System.Globalization;

namespace Exercicio_individual_Tema_Atividades_Complementares_12_10_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENTRE COM UM NÚMERO DE DE PESSOAS: ");
            int n = int.Parse(Console.ReadLine()); //Criando a variável de entrada do usuario

            double[] vect = new double[n]; //Criando vetor com o número da variável de entrada do usuario

            for (int i = 0; i < n; i++) //Utilização do comando for para percorrer o vetor
            {
                Console.Write("ALTURA DA PESSOA " + (i + 1) + ": "); //Pede a altura para o usuario
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //Entrada dos elementos no vetor pelo usuário
            }

            double sum = 0.0; //Variável soma  

            for (int i = 0; i < n; i++) //Utilização do for para percorrer o vetor
            {
                sum += vect[i]; //Somatoriados elementos inseridos
            }

            sum = sum / n; //Faz o calculo da media

            Console.WriteLine("A MÉDIA DE ALTURA DAS PESSOAS INSERIDAS É = " + sum.ToString("F2", CultureInfo.InvariantCulture)); // Mostra no console a media das alturas inseridas

            Console.ReadKey();
        }
    }
}
