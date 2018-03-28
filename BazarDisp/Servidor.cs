﻿using System;
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
        static Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

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
            Console.ReadLine();
        }

        public void HiloCliente(object socket)
        {
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
                
            }

            try
            {
                mensajeCliente = sr.ReadLine();
                Console.WriteLine(bazar.textBox1.Text + ": " + mensajeCliente);
                if (mensajeCliente == null)
                {
                    mensajeCliente = "#salir";

                    /////////
                    switch (mensajeCliente.ToLower())
                    {
                        case "#lista":

                            break;

                        case "#pedir":
                            break;

                        case "#salir":
                            sw.WriteLine("\t\t\t - HASTA LA PROXIMA " + bazar.textBox1.Text + " --");
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
                Console.WriteLine("SE HA DESCONECTADO EL AGENTE");

            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine(bazar.textBox1.Text + " SE HA DESCONECTADO");

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
