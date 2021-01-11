using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Ejercicio1
{
    class Program
    {

        static void Main(string[] args)
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, 31416);
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
            ProtocolType.Tcp);
            s.Bind(ie);
            s.Listen(10);
            Socket sClient = s.Accept();
            IPEndPoint ieClient = (IPEndPoint)sClient.RemoteEndPoint;
            Console.WriteLine("Client connected:{0} at port {1}", ieClient.Address,
            ieClient.Port);
            NetworkStream ns = new NetworkStream(sClient);
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            string msg = "Welcome\n";
            sw.Write(msg);
            sw.Flush();

            string command = "";
            while (command != null)
            {
                try
                {
                    command = sr.ReadLine();
                    if (command != null)
                    {
                        switch (command)
                        {
                            case "HORA":
                                sw.WriteLine("The current time is {0}", CurrentTime());
                                sw.Flush();
                                break;
                            case "FECHA":
                                sw.WriteLine("The current date is {0}", CurrentDate());
                                sw.Flush();
                                break;
                            case "TODO":
                                sw.WriteLine("The current time is {0}", CurrentTime());
                                sw.WriteLine("The current date is {0}", CurrentDate());
                                sw.Flush();
                                break;
                            case "APAGAR":
                                Console.WriteLine("Client disconnected.\nConnection closed");
                                sw.Close();
                                sr.Close();
                                ns.Close();
                                sClient.Close();
                                s.Close();
                                command = null;
                                break;
                            default:
                                break;
                        }
                    }
                }
                catch (IOException e)
                {
                    break;
                }
            }
            Console.WriteLine("Client disconnected.\nConnection closed");
            sw.Close();
            sr.Close();
            ns.Close();
            sClient.Close();
            s.Close();
        }

        public static string CurrentTime()
        {
            return DateTime.Now.ToString("h:mm:ss tt");

        }
        public static string CurrentDate()
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            return dateTime.ToString("dd/MM/yyyy");
        }
    }


}

/*
Realiza un servidor de fecha y hora. Aceptará los comandos: HORA (hora, minutos y segundos)),
FECHA (día, mes y año), TODO (hora y fecha), APAGAR (El servidor se cierra). Dependiendo del
comando que reciba enviará la información correspondiente.
 */