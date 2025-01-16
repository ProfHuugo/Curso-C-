using System;
using System.Collections.Generic;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter file full path:  ");
            string path = Console.ReadLine() ?? string.Empty;

            Dictionary<string,int> votingRecord = new Dictionary<string,int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = (sr.ReadLine() ?? string.Empty).Split(',');
                        string candidate = line[0];
                        int vote = int.Parse(line[1]);

                        // Verifica se a chave já existe no dicionário
                        if (votingRecord.ContainsKey(candidate))
                        {
                            votingRecord[candidate] += vote; // Atualiza os votos acumulados
                        }
                        else
                        {
                            votingRecord[candidate] = vote; // Adiciona um novo candidato
                        }
                    }
                }

                foreach (KeyValuePair<string, int> item in votingRecord)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }


            Console.ReadKey();
        }
    }
}