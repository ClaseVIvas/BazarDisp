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
        static int puerto = 31416;
        static bool ejecucion = true;
        static Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        string[] dips = new string[] {"One Plus","Motorola","Iphone X","Xiaomi MI MIX 2","Samsung S9"};
        List<string> dispositivos = new List<string>();

        // CODE
        public Servidor()
        {
            Inicio();
        }

        public void Inicio()
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, puerto);
            try
            {
                s.Bind(ie);
                s.Listen(3);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\t\t\t\t -- SERVIDOR BAZARDISP -- Puerto -> " + ie.Port);
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
            catch (SocketException e) when (e.ErrorCode == (int)SocketError.ConnectionRefused)
            {
                Console.WriteLine("Puerto {0} libre", puerto);
                Console.WriteLine("Error asignando puerto {0} , probando el siguiente ", puerto);
                puerto++;
                ie = new IPEndPoint(IPAddress.Any, puerto);
            }
            // Cerramos la conexion del Servidor
            s.Close();
            Console.WriteLine("Terminando Conexion....");
        }

        public void HiloCliente(object socket)
        {
            string mensajeCliente = "";
            
            Socket clienteH = (Socket)socket;
            IPEndPoint ieCliente = (IPEndPoint)clienteH.RemoteEndPoint;
            //
            Console.WriteLine("\t -- Cliente Conectado {0} en el Puerto {1}", ieCliente.Address, ieCliente.Port);
            //
            NetworkStream ns = new NetworkStream(clienteH);
            StreamWriter sw = new StreamWriter(ns);
            StreamReader sr = new StreamReader(ns);
            sw.AutoFlush = true;
            //
            foreach(string item in dips)
            {
                dispositivos.Add(item);
            }
            //
            //

            try
            {
                string bienvenida = "\t\t -- BIENVENIDO AL SERVIDOR  --";
                sw.WriteLine(bienvenida);
                sw.WriteLine("\t Haga Click En los Botones Para Realizar las Siguientes Opciones");
                sw.WriteLine("Dispositivos - Visualice todos los dipositivos que hay ahora Mismo");
                sw.WriteLine("Hacer Pedido - Haga una peticion sobre un dispositivo que no tengamos y se lo pediremos");
                sw.WriteLine("Salir - Finalizar Sesion");
                //
                mensajeCliente = sr.ReadLine();
                if (mensajeCliente != null)
                {
                    Console.WriteLine("Phili : " + mensajeCliente);
                    /////////
                    switch (mensajeCliente)
                    {
                        case "Dispositivos":
                            foreach(string item in dispositivos)
                            {
                                sw.WriteLine(item);
                            }
                            break;

                        case "Salir":
                            sw.WriteLine("\t\t\t - HASTA LA PROXIMA  --");
                            ejecucion = false;
                            break;
                        default:
                            sw.WriteLine("Comando No Reconocido");
                            break;
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("SE HA DESCONECTADO EL Cliente");

            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine(" SE HA DESCONECTADO");

            }
            // FINALIZAMOS CONEXION
            Console.WriteLine("\t Conexion Finalizada con {0}:{1}", ieCliente.Address, ieCliente.Port);
            ns.Close();
            sw.Close();
            sr.Close();
            clienteH.Close();
        }
    }
}
