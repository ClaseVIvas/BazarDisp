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
    public partial class FrmDispositivos : Form
    {

        public FrmDispositivos()
        {
            InitializeComponent();
        }

        public FrmDispositivos(string img,string nombreDisp , string textoPantalla, string textoCamara, string textoBateria, string textoSistema)
        {
            InitializeComponent();
            pctbDispositivo.Image = Image.FromFile(img);
            lblDispositivo.Text = nombreDisp;
            lbltextPantalla.Text = textoPantalla;
            lbltextCamara.Text = textoCamara;
            lbltextBateria.Text = textoBateria;
            lbltextSistema.Text = textoSistema;
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
