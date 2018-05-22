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
    public partial class FormPedido : Form
    {
        public FormPedido()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;

                string marca = cmBMarca.SelectedItem.ToString();

                string color = cmBColor.SelectedItem.ToString();

                string tamaño = cmBTamaño.SelectedItem.ToString();

                NuevoMovil nuevoMovil = new NuevoMovil(nombre, marca, color, tamaño);

                MessageBox.Show("Datos Enviados A la Frabrica: " + nuevoMovil.Nombre + "\r\n" + nuevoMovil.Marca + "\r\n" + nuevoMovil.Color + "\r\n" + nuevoMovil.Tamaño, "BazarDis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("ERROR: No puede Dejar Ningun Campo Sin Completar","BazarDisp",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = true;

        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
