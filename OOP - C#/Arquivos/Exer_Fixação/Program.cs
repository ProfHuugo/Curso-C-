using System.IO;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Devv\Source.csv"; // Caminho do arquivo de origem
            string targetPath = @"D:\Devv\Summary.csv"; // Caminho do arquivo de destino

            try
            {
                // Lê todas as linhas do arquivo Source.csv
                string[] lines = File.ReadAllLines(sourcePath);

                // Dicionário para armazenar o total por produto (nome do produto, total acumulado)
                Dictionary<string, double> productTotals = new Dictionary<string, double>();

                foreach (string line in lines)
                {
                    // Divide a linha em colunas (Nome, Preço, Quantidade)
                    string[] columns = line.Split(',');

                    // Pega os valores das colunas
                    string productName = columns[0];
                    double price = double.Parse(columns[1], CultureInfo.InvariantCulture);
                    int quantity = int.Parse(columns[2]);

                    // Calcula o total (preço * quantidade)
                    double total = price * quantity;

                    // Soma ao total existente no dicionário ou adiciona um novo item
                    if (productTotals.ContainsKey(productName))
                    {
                        productTotals[productName] += total;
                    }
                    else
                    {
                        productTotals[productName] = total;
                    }
                }

                // Escreve o arquivo Summary.csv
                using (StreamWriter sw = new StreamWriter(targetPath))
                {
                    foreach (var entry in productTotals)
                    {
                        string productName = entry.Key;
                        double total = entry.Value;

                        // Escreve no formato "Nome, Total"
                        sw.WriteLine($"{productName},{total.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }

                Console.WriteLine("Arquivo Summary.csv criado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
