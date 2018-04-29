using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.ComponentModel;
namespace ServidroBazarDisp
{
    class Program
    {
        // DECLARACION DE VARIABLES
        static int puerto = 31416;
        static bool ejecucion = true;
        static Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static string[] dips = { "One Plus", "Motorola", "Iphone X", "Xiaomi MI MIX 2", "Samsung S9" };
        static List<string> dispositivos = new List<string>();
        private static NetworkStream ns;
        private static StreamReader sr;
        private static StreamWriter sw;

        static void Main(string[] args)
        {
            Inicio();

        }

        static public void Inicio()
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, puerto);
            try
            {
                s.Bind(ie);
                s.Listen(5);
                Console.WriteLine("\t\t\t\t -- SERVIDOR BAZARDISP -- Puerto -> " + ie.Port);
                //
                while (ejecucion)
                {
                    if (ejecucion)
                    {
                        Socket cliente = s.Accept();
                        Thread hilo = new Thread(HiloCliente);
                        hilo.Start(cliente);
                        hilo.Join();
                    }
                }
            }
            catch (SocketException v) when (v.ErrorCode == (int)SocketError.ConnectionRefused)
            {
                Console.WriteLine("Puerto {0} libre", puerto);
                Console.WriteLine("Error asignando puerto {0} , probando el siguiente ", puerto);
                puerto++;
                ie = new IPEndPoint(IPAddress.Any, puerto);
            }
            // Cerramos la conexion del Servidor
            Console.WriteLine("Terminando Conexion....");
            s.Close();
        }

        static public void HiloCliente(object socket)
        {
            Socket socketCliente = socket as Socket;
            IPEndPoint ieCliente = (IPEndPoint)(socket as Socket).RemoteEndPoint;
            string mensajeCliente = "";
            ns = new NetworkStream(socketCliente);
            sr = new StreamReader(ns);
            sw = new StreamWriter(ns);
            sw.AutoFlush = true;
            //
            Console.WriteLine("\t -- Cliente Conectado {0} en el Puerto {1}", ieCliente.Address, ieCliente.Port);
            foreach (string item in dips)
            {
                dispositivos.Add(item);
            }
            sw.WriteLine("BIENVENIDO AL ALMACEN\r\n" + "Estos Son Los Actuales Dispositivos que estan En Stock\r\n");

            mensajeCliente = sr.ReadLine();
            try
            {
                Console.WriteLine(ieCliente.Address + ": " + mensajeCliente);
                if (mensajeCliente != null)
                {
                    switch (mensajeCliente)
                    {
                        case "Dispositivos":
                            int cont = 1;
                            //
                            foreach (String item in dispositivos)
                            {
                                sw.WriteLine(cont + " -> " + item + "\r\n");
                                cont++;
                                Console.WriteLine(item);
                            }
                            //BaseDatos bd = new BaseDatos();
                            //sw.WriteLine("LISTA");
                            //foreach (string item in dispositivos)
                            //{
                            //    sw.WriteLine(item);
                            //}
                            break;
                        case "Salir":
                            sw.WriteLine("HASTA LA PROXIMA " + ieCliente.Address + " --");
                            ejecucion = false;
                            break;
                        default:
                            sw.WriteLine("Comando No Reconocido");
                            break;
                    }
                }
            }
            catch (IOException a)
            {
                Console.WriteLine("SE HA DESCONECTADO EL CLIENTE: -> " + a.Message);

            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine(ieCliente.Address + " SE HA DESCONECTADO");

            }
            // FINALIZAMOS CONEXION
            Console.WriteLine("\t Conexion Finalizada con {0}:{1}", ieCliente.Address, ieCliente.Port);
            sr.Close();
            sw.Close();
            ns.Close();
            socketCliente.Close();
        }

    }
}
