//****************************************************************
// Programmer: Grace Toyer CIT014747
// Date: 25/11/2019
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: Assessment 5 Task 2 - Client Application. Acts as a client that creates a tcp connection with a server.
// Adapted from: https://www.c-sharpcorner.com/article/socket-programming-in-C-Sharp/
//******************************************************************
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Client
{
    public static int Main(string[] args)
    {
        StartClient();
        return 0;
    }

    public static void StartClient()
    {
        byte[] bytes = new byte[1024];

        try
        {
            //Get the host IP to establish connection
            IPHostEntry host = Dns.GetHostEntry("localhost");//change to ip address for use over network instead of local
            IPAddress ip = host.AddressList[0];//gets one or many ip addresses
            IPEndPoint remoteEP = new IPEndPoint(ip, 11000);

            //creates a socket using TCP
            Socket sender = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try//connect to the server (remoteEP)
            {
                sender.Connect(remoteEP);

                Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());
                int bytesRec = sender.Receive(bytes);
                Console.WriteLine("Response = {0}", Encoding.ASCII.GetString(bytes, 0, bytesRec));

                string input;
 
                input = Console.ReadLine();//gets the user input

                byte[] msg = Encoding.ASCII.GetBytes(input + " <EOF>");//converts entered string into bytes ready to send back to the server

                int bytesSent = sender.Send(msg);//sends the data to the server

                bytesRec = sender.Receive(bytes);//get response back from the server
                Console.WriteLine("Response = {0}", Encoding.ASCII.GetString(bytes, 0, bytesRec));

                sender.Shutdown(SocketShutdown.Both);//stops the server and client sockets 
                sender.Close();
            }
            //catch errors
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
            }
            catch (Exception e)//catch all other errors
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

        Console.WriteLine("\nPress key to close...");//waits to close the console until key pressed
        Console.ReadKey();
    }
}


