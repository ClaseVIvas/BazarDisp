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
    public partial class FrmSeleccionDispositivo : Form
    {
        int x, y;
        int oriX = 60;
        int numColumnas = 2;
        int separacionHorizontal = 210;
        int separaciónVertical = 139;
        Size tamañoImagenes = new Size(200, 133);

        public FrmSeleccionDispositivo()
        {
            InitializeComponent();
        }

        private void FrmSeleccionDispositivo_Load(object sender, EventArgs e)
        {
            lbltextInfo.Text = "Estos Son Los Dispositivo Disponibles. \r\n Selecciona Alguno para ver sus Caracteristicas Basicas";
        }

        public void CreadImagenesDispositivos(string marca)
        {
            for (int i = 0; i < 4; i++)
            {
                if (i % numColumnas == 0)
                {
                    x = oriX;
                    y += separaciónVertical;
                }
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = tamañoImagenes;
                pictureBox.Location = new Point(x, y);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile(@"imagen_dispositivos\" + marca + "\\"+i+".jpg");
                pictureBox.MouseClick += new MouseEventHandler(ClickBoton);
                pictureBox.Tag = i;
                Controls.Add(pictureBox);
                x += separacionHorizontal;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ClickBoton(object sender, MouseEventArgs e)
        {
            PictureBox pctBox = sender as PictureBox;
            int imagenSeleccionada = Convert.ToInt32(pctBox.Tag);
            switch (imagenSeleccionada)
            {
                case 0:
                    // APPLE
                    try
                    {
                        Dispositivos dispositivos = new Dispositivos();
                        dispositivos.Apple(@"imagen_dispositivos\apple\0.jpg", "iphone x",
                                            "tamaño \r\n" +
                                            "5.8 pulgadas \r\n\r\n" +
                                            "resolución \r\n" +
                                            "1125 x 2436 px \r\n\r\n" +
                                            "densidad \r\n" +
                                            "463 ppi (pixeles por pulgada)",
                                            "primaria \r\n" +
                                            "12 mp (4032 x 3024 px)\r\n\r\n" +
                                            "secundaria\r\n" +
                                            "7 mp (3088 x 2320 px)",
                                            "capacidad \r\n" +
                                            "2716 mah\r\n\r\n" +
                                            "autonomia de conversación (3g)\r\n" +
                                            "21 horas",
                                            "soc \r\n" +
                                            "apple a11 bionic apl1w72 \r\n\r\n" +
                                            "memoria ram\r\n" +
                                            "3 gb");

                    }
                    catch (Exception v)
                    {
                        MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 1:

                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }

        public FrmDispositivos DispositivoSeleccionado(string img, string nombreD, string pantalla, string camara, string bateria, string sistema)
        {
            FrmDispositivos dispositivos = new FrmDispositivos(img, nombreD, pantalla, camara, bateria, sistema);
            dispositivos.Show();
            return dispositivos;
        }
    }
}
