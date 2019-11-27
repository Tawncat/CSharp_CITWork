//****************************************************************
// Programmer: Grace Toyer CIT014747
// Date: 25/11/2019
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: Assessment 5 Task 2 - Server Application. Acts as a server that creates and opens a tcp connection.
// Adapted from: https://www.c-sharpcorner.com/article/socket-programming-in-C-Sharp/
//******************************************************************
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class Server
{
    public static int Main(String[] args)
    {
        StartServer();
        return 0;
    }

    public static void StartServer()
    {
        //Get the host IP to establish connection
        IPHostEntry host = Dns.GetHostEntry("localhost");//change to ip address for use over network instead of local
        IPAddress ip = host.AddressList[0];//gets one or many ip addresses
        IPEndPoint localEndPoint = new IPEndPoint(ip, 11000);

        try
        {
            //creates a socket using TCP
            Socket listener = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(localEndPoint);//assign an endpoint
            listener.Listen(10);//how many different requests allowed at the same time

            Console.WriteLine("Waiting for a connection...");

            Socket handler = listener.Accept();//creates a new socket for a connection

            //to hold client data
            string data = null;
            byte[] bytes = null;

            byte[] msg = Encoding.ASCII.GetBytes("Enter your name: ");//prompts client to enter a string
            handler.Send(msg);

            while (true)
            {
                bytes = new byte[1024];
                int bytesRec = handler.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);//decodes the client message back into a string

                if (data.IndexOf("<EOF>") > -1)
                {
                    break;
                }
            }

            Console.WriteLine("String Recieved : {0}", data);//prints recieved data

            msg = Encoding.ASCII.GetBytes("Hello " + data);//encodes string into byte array and sends data back to client
            handler.Send(msg);
            handler.Shutdown(SocketShutdown.Both);//stops the server and client sockets 
            handler.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());//prints the error to the screen
        }

        Console.WriteLine("\nPress key to close...");//waits to close the console until key pressed
        Console.ReadKey();
    }
}

