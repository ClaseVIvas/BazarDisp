using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.ComponentModel;

namespace BazarDisp
{
    class ServidorBazar
    {
        // DECLARACION DE VARIABLES
        static int puerto = 31416;
        static bool ejecucion = true;
        static Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        NuevoMovil nuevo;
        static List<string> dispositivos = new List<string>();
        static string Nombre;
        static string Marca;
        static string Color;
        static string Tamaño;

        public ServidorBazar()
        {
            Thread hiloServ = new Thread(Inicio);
            hiloServ.Start();
        }

        public void Inicio()
        {
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
            catch (SocketException m)
            {
                Console.WriteLine("ERROR: " + m.Message);
            }
            catch (ObjectDisposedException k)
            {
                Console.WriteLine("ERROR: " + k.Message);
            }
            // Cerramos la conexion del Servidor
            Console.WriteLine("Terminando Conexion....");
            s.Close();
        }

        public void DatosRecibidos(string nombre, string marca, string color, string tamaño)
        {
            Nombre = nombre;
            Marca = marca;
            Color = color;
            Tamaño = tamaño;
        }

        public void HiloCliente(object socketCliente)
        {
            string mensajeCliente = "";
            Socket cliente = (Socket)socketCliente; // Utilizacion de Variable
            IPEndPoint ieCliente = (IPEndPoint)cliente.RemoteEndPoint; // Variable para referirse a la conexio
            //
            Console.WriteLine("\t -- Cliente Conectado {0} en el Puerto {1}", ieCliente.Address, ieCliente.Port);
            NetworkStream ns = new NetworkStream(cliente);
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true;

            dispositivos.Add("Nombre: "+Nombre + "\r\nMarca: "+Marca+ "\r\nColor: " + Color+ "\r\nTamaño: " + Tamaño);
            sw.WriteLine("BIENVENIDO AL ALMACEN\r\n" + "Estos Son Los Actuales Dispositivos que estan En Fabricacion \r\n");

            try
            {
                mensajeCliente = sr.ReadLine();
                Console.WriteLine(ieCliente.Address + ": " + mensajeCliente);
                if (mensajeCliente != null)
                {
                    switch (mensajeCliente)
                    {
                        case "Dispositivos":
                            foreach (string item in dispositivos)
                            {
                                sw.WriteLine("DISPOSITIVO\r\n"+item + "\r\n");
                                Console.WriteLine(item);
                            }

                            break;
                        case "Salir":
                            sw.WriteLine("¡ HASTA LA PROXIMA !");
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
            cliente.Close();
        }
    }
}
