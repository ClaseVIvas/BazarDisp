using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;


namespace ServidorBazarDisp
{
    class Servidor
    {

        // DECLARACION DE VARIABLES
        int puerto = 31416;
        static Socket clienteH;
        static bool finJuego = true;
        //
        NetworkStream ns;
        StreamWriter sw;
        StreamReader sr;

        // CODE
        public Servidor()
        {
            Inicio();
        }

        public void Inicio()
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, puerto);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socket.Bind(ie);
                socket.Listen(2);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\t\t\t\t -- SERVIDOR BAZARDISP -- Puerto -> " + ie.Port);
                while (true)
                {

                    Socket clienteC = socket.Accept();
                    Thread hilo = new Thread(HiloCliente);

                    hilo.Start(clienteC);
                }
            }
            catch (SocketException e) when (e.ErrorCode == (int)SocketError.ConnectionRefused)
            {
                Console.WriteLine("Puerto {0} libre", puerto);
                Console.WriteLine("Error asignando puerto {0} , probando el siguiente ", puerto);
                puerto++;
                ie = new IPEndPoint(IPAddress.Any, puerto);
            }
            // Cerramos la conexion del Servidor
            socket.Close();
            Console.WriteLine("Terminando Conexion....");
            Console.ReadLine();
        }

        public void HiloCliente(object socket)
        {
            string mensajeCliente = "";

            Random numAleatorio = new Random();
            clienteH = (Socket)socket;
            IPEndPoint ieCliente = (IPEndPoint)clienteH.RemoteEndPoint;
            //
            NetworkStream ns = new NetworkStream(clienteH);
            StreamWriter sw = new StreamWriter(ns);
            StreamReader sr = new StreamReader(ns);
            sw.AutoFlush = true;
            //
            //
            try
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                string bienvenida = "\t\t -- BIENVENIDO AL SERVIDOR " + bazar.textBox1.Text + " --";
                sw.WriteLine(bienvenida);
                //
                sw.WriteLine("\t Introduzca los siguientes comandos para trabajar en el servidor");
                sw.WriteLine("#lista - Visualice todos los dipositivos que hay ahora Mismo");
                sw.WriteLine("#pedir - Haga una peticion sobre un dispositivo que no tengamos y se lo pediremos");
                sw.WriteLine("#salir - Finalizar Sesion");
            }
            catch (ObjectDisposedException)
            {
                CierraConexion();
            }
            while (finJuego)
            {
                try
                {
                    mensajeCliente = sr.ReadLine();
                    Console.WriteLine(bazar.textBox1.Text + ": " + mensajeCliente);
                    if (mensajeCliente == null)
                    {
                        mensajeCliente = "#salir";
                    }
                    /////////
                    switch (mensajeCliente.ToLower())
                    {
                        case "#lista":
                            break;

                        case "#pedir":
                            break;

                        case "#salir":
                            sw.WriteLine("\t\t\t - HASTA LA PROXIMA " + bazar.textBox1.Text + " --");
                            CierraConexion();
                            break;
                        default:
                            sw.WriteLine("Comando No Reconocido");
                            break;
                    }
                }
                catch (IOException)
                {
                    Console.WriteLine("SE HA DESCONECTADO EL AGENTE");
                    CierraConexion();
                    break;
                }
                catch (ObjectDisposedException)
                {
                    Console.WriteLine(bazar.textBox1.Text + " SE HA DESCONECTADO");
                    CierraConexion();
                    break;
                }
            }
        }

        public void CierraConexion()
        {
            ns.Close();
            sw.Close();
            sr.Close();
            clienteH.Close();
            finJuego = false;
        }
    }
}
