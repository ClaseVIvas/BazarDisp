using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazarDisp
{
    public partial class FormInicio : Form
    {
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
            Servidor servidor = new Servidor();
            servidor.Inicio();

        }
    }
}
