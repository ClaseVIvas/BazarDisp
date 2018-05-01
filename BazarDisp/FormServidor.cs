using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace BazarDisp
{
    public partial class FormServidor : Form
    {
        //DECLARACION DE VARIALBES
        string IPCliente = "127.0.0.1";
        int puertoCliente = 31416;
        string mensajeServidor;
        Socket servidor = null;
        //

        //CODE
        public FormServidor()
        {
            InitializeComponent();
        }

        public void Conexion()
        {
            try
            { 
                servidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ie = new IPEndPoint(IPAddress.Parse(IPCliente), puertoCliente);
                servidor.Connect(ie);
                MessageBox.Show("SERVIDOR ACTIVADO");
            }
            catch (SocketException e)
            {
                MessageBox.Show(String.Format("Error de conexión con servidor: {0} \r\n Código de error: {1}({2})", e.Message, (SocketError)e.ErrorCode, e.ErrorCode), "BAZARDISP");
            }
        }


        private void PulsaComando(object sender, EventArgs e)
        {
            try
            {
                ServidorBazar server = new ServidorBazar();

                Conexion();
                txtbServidor.Text = "";
                Button btnComando = sender as Button;
                NetworkStream ns = new NetworkStream(servidor);
                StreamReader sr = new StreamReader(ns);
                StreamWriter sw = new StreamWriter(ns);

                //ENVIAMOS LOS DATOS AL SERVIDOR
                sw.WriteLine(btnComando.Text);
                sw.Flush();
                //
                mensajeServidor = sr.ReadToEnd();
                txtbServidor.Text = mensajeServidor;
                //
                ns.Close();
                sr.Close();
                sw.Close();

                servidor.Close(); // CERRAMOS EL SERVIDOR

                if (btnComando.Text == "Salir")
                {
                    servidor.Close();
                    Close();
                }
            }
            catch (IOException a)
            {
                MessageBox.Show("ERROR FormServidor: " + a.Message);
            }
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            FormPedido pedido = new FormPedido();
            pedido.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseDatos bd = new BaseDatos();
            MessageBox.Show("BASE DE DATOS ACTIVA");
        }
    }
}
