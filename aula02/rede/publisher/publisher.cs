using System;
using System.Net.Sockets;
using System.Text;


class Program
{
    static void Main()
    {
        string Ip = "subscriber-audaces"; 
        int Port = 4546;

        //steam
        using (var client = new TcpClient(Ip,Port))
        using (var stream = client.GetStream())
       {
        string message = "Essa mensagem foi emitida pelo publisher!";
        byte[] data = Encoding.UTF8.GetBytes(message);
        stream.Write(data, 0, data.Length);
        Console.WriteLine("Mensagem Enviada com Sucesso!!!");
        } 
        
    }
}

