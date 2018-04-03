using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace BazarDisp
{
    class Servidor2
    {
        // DECLARACION DE VARIABLES
        static int puerto = 31416;
        static bool ejecucion = true;

        public Servidor2()
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, puerto);
            try
            {
                s.Bind(ie);
                s.Listen(3);
                Console.WriteLine("\t\t\t\t -- SERVIDOR BAZARDISP -- Puerto -> " + ie.Port);

                Socket cliente = s.Accept();
                Thread hilo = new Thread(HiloCliente);
                hilo.Start(cliente);
                //hilo.Join();

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

        public void HiloCliente()
        {
            while (ejecucion)
            {
                Console.WriteLine("Hola soy un hilo chorras que escribe cada 5s" +
                          "en consola mientras sigues jugueteando con un formulario");
                Thread.Sleep(5000);
            }
        }
    }
}
