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
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent();
        }

        private void FormBienvenida_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult resp = MessageBox.Show("¿ Desea Salir de La Aplicacion ?", "BazarDisp", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            switch (resp)
            {
                case DialogResult.OK:
                    e.Cancel = false;
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
