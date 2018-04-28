using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace BazarDisp
{
    public partial class FormInicio : Form
    {
        // DECLARACION DE VARIABLES
        static FormBienvenida bazar = new FormBienvenida();
        FormServidor serv;
        string rutaMarcas;
        DirectoryInfo imagenes_Marcas;
        int x, y;
        int oriX = 3;
        int numColumnas = 4;
        int separacionHorizontal = 208;
        int separaciónVertical = 139;
        Size tamañoImagenes = new Size(200, 133);
        bool aceptar = true;

        // CODE
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            try
            {
                do
                {
                    switch (bazar.ShowDialog())
                    {
                        case DialogResult.OK:
                            if (bazar.txtNombreCliente.Text == "")
                            {
                                aceptar = false;
                                MessageBox.Show("Introduce Un Nombre Porfavor", "BazarDisp.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                aceptar = true;
                                lblCliente.Text = "BIENVENIDO " + bazar.txtNombreCliente.Text;
                                CreadImagenes();
                            }
                            break;
                        case DialogResult.Cancel:
                            Close();
                            break;
                    }
                } while (!aceptar);
            }
            catch (ObjectDisposedException d)
            {
                MessageBox.Show("BAZARDISP", "¡ Hasta la Próxima !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void CreadImagenes()
        {
            imagenes_Marcas = new DirectoryInfo("image_marcas");

            //foreach (FileInfo item in imagenes_Marcas.GetFiles("*png"))
            //{
            //    PictureBox pictureBox = new PictureBox();
            //    pictureBox.Size = new Size(200, 133);
            //    pictureBox.Location = new Point(x, y);
            //    Console.WriteLine(item);
            //    pictureBox.Image = Image.FromFile(@"image_marcas\" + item);
            //    Controls.Add(pictureBox);
            //    pnlImagenes.Controls.Add(pictureBox);
            //    nuevaI = y * 150;
            //}

            for (int i = 0; i < 20; i++)
            {
                if (i % numColumnas == 0)
                {
                    x = oriX;
                    y += separaciónVertical;
                }
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = tamañoImagenes;
                pictureBox.Location = new Point(x, y);
                Console.WriteLine("POSICION X -> " + x + "\n" + "POSICION Y -> " + y + "\n" + i + ".png");
                pictureBox.Image = Image.FromFile(@"image_marcas\" + i + ".png");
                pictureBox.MouseClick += new MouseEventHandler(ClickBoton);
                Controls.Add(pictureBox);
                x += separacionHorizontal;
            }
        }

        public void ClickBoton(object sender, MouseEventArgs e)
        {

        }

        private void btnIniciaServidor_Click(object sender, EventArgs e)
        {
            serv = new FormServidor();
            try
            {
                switch (serv.ShowDialog())
                {
                    case DialogResult.OK:
                        break;
                    case DialogResult.Cancel:
                        serv.Close();
                        break;
                }
            }
            catch (Exception) { }
        }
    }
}
