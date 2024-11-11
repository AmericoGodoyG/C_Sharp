using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace VetoresClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício que  Vetor que armazena objetos do tipo classe
            Console.Write("Quanto produtos serão cadastrados: ");
            int n = int.Parse(Console.ReadLine());

            /*
                Na stack é criada um vetor products
                que está apontando para heap 
                onde estão localizados os objetos 
                com espaços nulos.
                
                Nulo é o valor padrão para o tipo referência
            
                Instanciando um vetor, porém, está instanciado como nulo
                porque o nulo é o valor padrão para o tipo referencia
                
                Ao instanciar um vetor é necessário instanciar os objetos 
                dentro de cada "caixa" do vetor.
                
             */
            Product[] products = new Product[n];


            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                // Instanciando um produto na posição i
                products[i] = new Product { Name = name, Price = price };
            }

            // Exibindo o array de produtos
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Produto na {i+1}ª posição");
                Console.WriteLine(products[i]);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += products[i].Price;
            }
            double avg = sum / n;
            Console.WriteLine(" Média de preços R$ " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
