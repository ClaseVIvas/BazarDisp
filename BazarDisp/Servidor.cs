using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace BazarDisp
{
    class Servidor
    {

        // DECLARACION DE VARIABLES
        static int puerto = 31416;
        static bool ejecucion = true;
        string[] dips = new string[] { "One Plus", "Motorola", "Iphone X", "Xiaomi MI MIX 2", "Samsung S9" };
        List<string> dispositivos = new List<string>();

        // CODE
        public Servidor()
        {
            Thread hilo = new Thread(Inicio);
            hilo.Start();
        }


        public void Inicio()
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, puerto);
            try
            {
                s.Bind(ie);
                s.Listen(3);
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
            Console.ReadLine();

        }

        public void HiloCliente(object socket)
        {
            //
            string mensajeCliente = "";
            FormBienvenida bazar = new FormBienvenida();
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
            foreach (string item in dips)
            {
                dispositivos.Add(item);
            }
            //

            //string bienvenida = "BIENVENIDO AL SERVIDOR " + bazar.txtNombreCliente.Text;
            //Console.WriteLine(bazar.txtNombreCliente.Text);
            //sw.WriteLine(bienvenida);
            //
            sw.WriteLine("Al Presionar Los Botones: \r\n "+ "Dispositivos - Visualice todos los dipositivos que hay ahora Mismo \r\n"+ "Salir - Finalizar Sesion");

            try
            {
                mensajeCliente = sr.ReadLine();
                Console.WriteLine(bazar.txtNombreCliente.Text + ": " + mensajeCliente);
                if (mensajeCliente != null)
                {
                    mensajeCliente = "#salir";
                    
                    /////////
                    switch (mensajeCliente.ToLower())
                    {
                        case "Dispositivos":
                            sw.WriteLine("LISTA");
                            foreach (string item in dispositivos)
                            {
                                sw.WriteLine(item);
                            }
                            break;

                        case "#salir":
                            sw.WriteLine("HASTA LA PROXIMA " + bazar.txtNombreCliente.Text + " --");
                            ejecucion = false;
                            break;
                        default:
                            sw.WriteLine("Comando No Reconocido");
                            break;
                    }
                }
                ejecucion = false;
            }
            catch (IOException)
            {
                Console.WriteLine("SE HA DESCONECTADO EL AGENTE");

            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine(bazar.txtNombreCliente.Text + " SE HA DESCONECTADO");

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

