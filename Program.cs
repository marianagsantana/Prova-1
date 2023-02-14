using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Prova1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prova 1!");

            try
            {
                String filePath = "arquivo.txt"; 

                string[] lines = File.ReadAllLines(filePath); // lê o arquivo
                int[] arrayDesordenado = new int[lines.Length]; // cria um array com o tamanho do arquivo
                SortedSet<int> setOrdenado = new SortedSet<int>(); // cria uma collection

                for (int i = 0; i < lines.Length; i++) // percorre o arquivo
                {
                    arrayDesordenado[i] = int.Parse(lines[i]); // adiciona o valor na posição do array
                    setOrdenado.Add(arrayDesordenado[i]); // adiciona o valor na collection
                }

                arrayDesordenado = BubbleSort(arrayDesordenado); // ordena o array com Bubble Sort

                Console.WriteLine("Valores ordenados no Array:"); //  imprime os valores
                foreach (var value in arrayDesordenado) 
                {
                    Console.WriteLine(value);
                }

                Console.WriteLine("Valores ordenados na Collection:");
                foreach (var value in setOrdenado)
                {
                    Console.WriteLine(value);
                }

                File.WriteAllLines("arquivoOrdenado.txt", arrayDesordenado.Select(x => x.ToString())); // escreve o array ordenado no arquivo
            }
            catch (Exception ex) //caso ocorra algum erro
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }

            Console.ReadKey(); 
        }

        static int[] BubbleSort(int[] array) // método de ordenação Bubble Sort
        {
            int n = array.Length; 
            for (int i = 0; i < n - 1; i++) 
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // troca os elementos
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
