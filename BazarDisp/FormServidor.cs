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
    public partial class FormServidor : Form
    {
        public FormServidor()
        {
            InitializeComponent();
        }

        private void FormServidor_Load(object sender, EventArgs e)
        {

        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            FormPedido pedido = new FormPedido();
            DialogResult resp = pedido.ShowDialog();
            if (resp == DialogResult.OK)
            {

            }
            else
            {
                pedido.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
