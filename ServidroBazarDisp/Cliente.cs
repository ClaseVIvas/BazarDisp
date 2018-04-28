using System;
using System.IO;
using System.Net.Sockets;

namespace ServidroBazarDisp
{
    public class Cliente
    {
        /// <summary>
        /// Mensaje del cliente
        /// </summary>
        public string Mensaje;

        /// <summary>
        /// Conexion del usuario
        /// </summary>
        private Socket socket;

        /// <summary>
        /// Flujo de comunicación
        /// </summary>
        private NetworkStream ns;

        /// <summary>
        /// Flujo de escritura
        /// </summary>
        private StreamWriter sw;

        /// <summary>
        /// Flujo de lectura
        /// </summary>
        private StreamReader sr;

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="T:ServidroBazarDisp.Cliente"/> .
        /// </summary>
        /// <param name="s">S.</param>
        public Cliente(Socket s)
        {
            socket = s;
            generarFlujos();
        }

        /// <summary>
        /// Inicializa los flujos del usuario de su Socket
        /// </summary>
        private void generarFlujos()
        {
            try
            {
                ns = new NetworkStream(socket);
                sr = new StreamReader(ns);
                sw = new StreamWriter(ns);
            }
            catch (IOException) { }
        }

        /// <summary>
        /// Envia un mensaje al usuario a través de su flujo de datos
        /// </summary>
        /// <param name="mensaje">Mensaje a enviar</param>
        public void mandarMensaje(string mensaje)
        {
            sw.WriteLine(mensaje);
            sw.Flush();
            //TODO salta excepcion al salir un cliente
        }

        /// <summary>
        /// Lee información desde el flujo de entrada del usuario y lo almacena en su variable Mensaje.
        /// </summary>
        public void leerMensaje()
        {
            string mensaje = "Desconexion";
            try
            {
                mensaje = sr.ReadLine();
            }
            catch (IOException)
            {
                mensaje = "Desconexion";
            }
            catch (ObjectDisposedException)
            {
                mensaje = "Desconexion";
            }
            if (mensaje == null)
            {
                mensaje = "Desconexion";
            }
            Mensaje = mensaje;
        }

        /// <summary>
        /// Cierra los flujos y conexion de la sesion del usuario.
        /// </summary>
        /// <returns></returns>
        public void cerrarSesion()
        {
            if (sr != null)
            {
                sr.Close();
            }
            if (sw != null)
            {
                sw.Close();
            }
            if (ns != null)
            {
                ns.Close();
            }
            if (socket != null)
            {
                socket.Close();
            }
        }
    }
}
