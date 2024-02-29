using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabBi
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double valor1;
            double valor2;
            double valor3;
            double valor4;
            double valor5;
            int opcaoEscolhida;

            Console.WriteLine("Equipe:");
            Console.WriteLine("\t-> Paulo Padilha");
            Console.WriteLine("\t-> Lucas Gabriel");
            Console.WriteLine("\t-> Guilherme Saldanha");

            Console.WriteLine("\nDigite 5 números para começar:");
            Console.WriteLine("\nPrimeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nSegundo valor: ");
            valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nTerceiro valor: ");
            valor3 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nQuarto valor: ");
            valor4 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nQuinto valor: ");
            valor5 = double.Parse(Console.ReadLine());


            do
            {
                Console.WriteLine("Escolha a opção desejada: ");
                Console.WriteLine("\t1 - Cálculo da média aritmética");
                Console.WriteLine("\t2 - Cálculo da mediana");
                Console.WriteLine("\t3 - Cálculo da variância amostral");
                Console.WriteLine("\t4 - Cálculo do desvio padrão");
                Console.WriteLine("\t5 - Cálculo do coeficiente de variação");
                Console.WriteLine("\t6 - Finalizar");
                string numDigitado = Console.ReadLine();
                opcaoEscolhida = int.Parse(numDigitado);

                double media;
                double mediana;
                double VarAmostral;
                double DesvPadrao;
                double CV;

                switch (opcaoEscolhida)
                {
                    case 1:
                        media = (valor1 + valor2 + valor3 + valor4 + valor5) / 5;
                        Console.WriteLine($"\n-> Média aritmética = {media}\n");
                        break;
                    case 2:
                        double[] lista = new double[5] {valor1, valor2, valor3, valor4, valor5};
                        Array.Sort(lista);
                        mediana = lista[2];
                        Console.WriteLine($"\n-> Mediana = {mediana}\n");
                        break;
                    case 3:
                        media = (valor1 + valor2 + valor3 + valor4 + valor5) / 5;
                        VarAmostral = (Math.Pow((valor1 - media),2) + Math.Pow((valor2 - media), 2) + Math.Pow((valor3 - media), 2) + Math.Pow((valor4 - media), 2) + Math.Pow((valor5 - media), 2)) / 4;
                        Console.WriteLine($"\n-> Variância amostral = {VarAmostral}\n");
                        break;
                    case 4:
                        media = (valor1 + valor2 + valor3 + valor4 + valor5) / 5;
                        DesvPadrao = Math.Sqrt((Math.Pow((valor1 - media), 2) + Math.Pow((valor2 - media), 2) + Math.Pow((valor3 - media), 2) + Math.Pow((valor4 - media), 2) + Math.Pow((valor5 - media), 2)) / 4);
                        Console.WriteLine($"\n-> Desvio padrão = {DesvPadrao} \n");
                        break;
                    case 5:
                        media = (valor1 + valor2 + valor3 + valor4 + valor5) / 5;
                        DesvPadrao = Math.Sqrt((Math.Pow((valor1 - media), 2) + Math.Pow((valor2 - media), 2) + Math.Pow((valor3 - media), 2) + Math.Pow((valor4 - media), 2) + Math.Pow((valor5 - media), 2)) / 4);
                        CV = DesvPadrao / media * 100; 
                        Console.WriteLine($"\n-> Coeficiente de variação = {Math.Round(CV,2)}%");

                        if (CV > 30)
                        {
                            Console.WriteLine("-> O conjunto de dados é heterogêneo.\n");
                        }
                        else
                        {
                            Console.WriteLine("-> O conjunto de dados é homogêneo.\n");
                        }
                        break;
                }
            } while (opcaoEscolhida != 6);
        }
    }
}
