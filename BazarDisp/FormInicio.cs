using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;

namespace BazarDisp
{
    public partial class FormInicio : Form
    {
        // DECLARACION DE VARIABLES
        string IPCliente = "127.0.0.1";
        int puertoCliente = 31416;
        string mensajeServidor;
        Socket servidor = null;


        // CODE
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            FormBienvenida bazar = new FormBienvenida();
            DialogResult resp = bazar.ShowDialog();
            switch (resp)
            {
                case DialogResult.OK:
                    label2.Text = "BIENVENIDO "+bazar.textBox1.Text;
                    break;
                case DialogResult.Cancel:
                    Close();
                    break;
            }
        }

        private void btnIniciaServidor_Click(object sender, EventArgs e)
        {
          //  Servidor servidor = new Servidor();
            FormServidor serv = new FormServidor();
            DialogResult resp;
            try
            {
               // servidor.Inicio();
                //Conexion();
                resp = serv.ShowDialog();
                switch (resp)
                {
                    case DialogResult.OK:

                        break;
                    case DialogResult.Cancel:
                        serv.Close();
                        break;
                }
            }
            catch (Exception)
            {


                
                
            }
        }

        public void Conexion()
        {
            try
            {
                servidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ie = new IPEndPoint(IPAddress.Parse(IPCliente), puertoCliente);

                servidor.Connect(ie);
               // lblComando.Text = "SE HA CONECTADO AL SERVIDOR";
            }
            catch (SocketException e)
            {
                MessageBox.Show(String.Format("Error de conexión con servidor: {0} \r\n Código de error: {1}({2})", e.Message, (SocketError)e.ErrorCode, e.ErrorCode), "CAMBIO DE IP Y PUERTO");
                return;
            }
            catch (FormatException)
            {

            }
        }
    }
}
