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
                var filePath = "arquivo.txt"; // arquivo.txt

                var lines = File.ReadAllLines(filePath); // lê todas as linhas do arquivo
                var arrayDesordenado = new int[lines.Length]; // cria um array com o tamanho do arquivo
                var setOrdenado = new SortedSet<int>(); // cria uma collection ordenada

                for (var i = 0; i < lines.Length; i++) // percorre o arquivo
                {
                    arrayDesordenado[i] = int.Parse(lines[i]); // adiciona o valor na posição do array
                    setOrdenado.Add(arrayDesordenado[i]); // adiciona o valor na collection
                }

                Array.Sort(arrayDesordenado); // ordena o array

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
    }
}
