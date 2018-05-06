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
            CreadImagenesDispositivos();
        }

        public void CreadImagenesDispositivos()
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
                pictureBox.Image = Image.FromFile(@"imagen_dispositivos\Apple\" + i + ".jpg");
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
                        string pantalla = "Tamaño \r\n" +
                                            "5.8 pulgadas \r\n\r\n" +
                                            "Resolución \r\n" +
                                            "1125 x 2436 px \r\n\r\n" +
                                            "Densidad \r\n" +
                                            "463 ppi (pixeles por pulgada)";

                        string camara = "Primaria \r\n" +
                                        "12 MP (4032 x 3024 px)\r\n\r\n" +
                                        "Secundaria\r\n" +
                                        "7 MP (3088 x 2320 px)";

                        string bateria = "Capacidad \r\n" +
                                         "2716 mAh\r\n\r\n" +
                                         "Autonomia de conversación (3G)\r\n" +
                                         "21 horas";
                        string sistema = "Soc \r\n" +
                                         "Apple A11 Bionic APL1W72 \r\n\r\n" +
                                         "Memoria RAM\r\n" +
                                         "3 GB";

                        FrmDispositivos dispositivos = new FrmDispositivos(@"imagen_dispositivos\Apple\0.jpg", "IPHONE X", pantalla, camara, bateria, sistema);
                        dispositivos.Show();


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
    }
}
