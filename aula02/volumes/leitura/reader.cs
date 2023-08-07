using System;
using System.IO;

class Program
{
    static void Main()
    {
        string caminho = "/app/data/escrita.txt";

        string conteudo = File.ReadAllText(caminho);

        Console.WriteLine($"O conteudo do arquivo é: {conteudo}");
    }
}