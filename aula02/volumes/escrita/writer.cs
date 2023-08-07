using System;
using System.IO;

class Program
{
    static void Main()
    {
        string conteudo = "Olá, este conteúdo foi escrito pelo container Docker!";
        string caminho = "/app/data/escrita.txt";

        File.WriteAllText(caminho,conteudo);
        Console.WriteLine($"O arquivo {caminho} foi escrito com sucesso");
    }
}