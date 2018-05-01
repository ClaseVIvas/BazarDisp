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
                pictureBox.Tag = i;
                Console.WriteLine(pictureBox.Tag = "Caja - " + i);
                Controls.Add(pictureBox);
                x += separacionHorizontal;
            }
        }

        public void ClickBoton(object sender, MouseEventArgs e)
        {
            PictureBox pctBox = sender as PictureBox;
            int imagenSeleccionada = Convert.ToInt32(pctBox.Tag);
            switch (imagenSeleccionada)
            {
                case 0:
                    
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;

            }
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
