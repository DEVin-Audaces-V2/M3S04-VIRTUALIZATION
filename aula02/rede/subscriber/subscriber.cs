using System;
using System.Net;
using System.Net.Sockets;
using System.Text;


class Program
{
    static void Main()
    {
        
        int port = 4546;

        var listener = new TcpListener(IPAddress.Any,port);
        listener.Start();
        Console.WriteLine("Startando Subscriber");
        Console.WriteLine("Aguardando Publisher");

        while (true)
        {

            using (var client = listener.AcceptTcpClient())
            using (var stream = client.GetStream())

            {
                byte[] data = new byte[256];
                int bytesRead = stream.Read(data, 0, data.Length);

                string message = Encoding.UTF8.GetString(data, 0, bytesRead);
                Console.WriteLine($"Mensagem Recebida: {message}");

            }


        }


    }
}
