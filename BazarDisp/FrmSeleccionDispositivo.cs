using System;
using System.Drawing;
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
        string marcaSelecionada;

        public FrmSeleccionDispositivo()
        {
            InitializeComponent();
        }

        private void FrmSeleccionDispositivo_Load(object sender, EventArgs e)
        {
            lbltextInfo.Text = "Estos Son Los Dispositivo Disponibles. \r\n Selecciona Alguno para ver sus Caracteristicas Básicas";
        }

        public void CreadImagenesDispositivos(string marca)
        {
            marcaSelecionada = marca;
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
                pictureBox.Image = Image.FromFile(@"imagen_dispositivos\" + marca + "\\" + i + ".jpg");
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
            Dispositivos dispositivos = new Dispositivos();

            if (marcaSelecionada == "Apple")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        // APPLE
                        try
                        {

                            dispositivos.Apple(@"imagen_dispositivos\Apple\0.jpg", "Iphone x",
                                                "Tamaño \r\n" +
                                                "5.8 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1125 x 2436 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "463 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "12 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "7 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "2716 mah\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "21 horas",
                                                "SoC \r\n" +
                                                "Apple a11 bionic apl1w72 \r\n\r\n" +
                                                "Memoria ram\r\n" +
                                                "3 gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 1:
                        dispositivos.Apple(@"imagen_dispositivos\Apple\1.jpg", "Iphone 7",
                                            "Tamaño \r\n" +
                                            "4.7 pulgadas \r\n\r\n" +
                                            "Resolución \r\n" +
                                            "750 x 1334 px \r\n\r\n" +
                                            "Densidad \r\n" +
                                            "326 ppi (pixeles por pulgada)",
                                            "primaria \r\n" +
                                            "12 Mp (4032 x 3024 px)\r\n\r\n",
                                            "Capacidad \r\n" +
                                            "1960 mAh\r\n\r\n" +
                                            "Autonomia de conversación (3g)\r\n" +
                                            "12 horas",
                                            "Soc \r\n" +
                                            "Apple A10 bionic APL1W72 \r\n\r\n" +
                                            "Memoria Ram\r\n" +
                                            "2 gb");

                        break;
                    case 2:

                        dispositivos.Apple(@"imagen_dispositivos\Apple\2.jpg", "Iphone 8",
                                            "Tamaño \r\n" +
                                            "4.7 pulgadas \r\n\r\n" +
                                            "Resolución \r\n" +
                                            "750 x 1334 px \r\n\r\n" +
                                            "Densidad \r\n" +
                                            "326 ppi (pixeles por pulgada)",
                                            "Primaria \r\n" +
                                            "12 mp (4032 x 3024 px)\r\n\r\n" +
                                            "Secundaria\r\n" +
                                            "7 mp (3088 x 2320 px)",
                                            "Capacidad \r\n" +
                                            "1821 mah\r\n\r\n" +
                                            "Autonomia de conversación (3g)\r\n" +
                                            "12 horas",
                                            "SoC \r\n" +
                                            "Apple A11 bionic APL1W72 \r\n\r\n" +
                                            "Memoria Ram\r\n" +
                                            "2 gb");
                        break;
                    case 3:
                        dispositivos.Apple(@"imagen_dispositivos\Apple\3.jpg", "Iphone 6S",
                                            "Tamaño \r\n" +
                                            "4.7 pulgadas \r\n\r\n" +
                                            "Resolución \r\n" +
                                            "750 x 1334 px \r\n\r\n" +
                                            "Densidad \r\n" +
                                            "326 ppi (pixeles por pulgada)",
                                            "Primaria \r\n" +
                                            "12 mp (4032 x 3024 px)\r\n\r\n" +
                                            "Secundaria\r\n" +
                                            "5 mp (3088 x 2320 px)",
                                            "Capacidad \r\n" +
                                            "1715 mah\r\n\r\n" +
                                            "Autonomia de conversación (3g)\r\n" +
                                            "240 horas",
                                            "SoC \r\n" +
                                            "Apple A9 bionic APL0898 \r\n\r\n" +
                                            "Memoria Ram\r\n" +
                                            "2 gb");
                        break;
                }
            }

            if (marcaSelecionada == "Xiaomi")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {

                            dispositivos.Xiaomi(@"imagen_dispositivos\Xiaomi\0.jpg", "Xiaomi Mi Max 2",
                                                "Tamaño \r\n" +
                                                "6.4 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 1920 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "342 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "12 Mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "5 Mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "5300 mah\r\n\r\n" +
                                                "Autonomia de Conversación (3g)\r\n" +
                                                "57 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 625 MSM8953 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "4 gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 1:
                        try
                        {

                            dispositivos.Xiaomi(@"imagen_dispositivos\Xiaomi\1.jpg", "Xiaomi Mi 7",
                                                "Tamaño \r\n" +
                                                "5.65 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 2160 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "427 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "16 Mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "8 Mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "4480 mah\r\n\r\n" +
                                                "Autonomia de Conversación (3g)\r\n" +
                                                "47 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 845 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "6 gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    case 2:
                        try
                        {

                            dispositivos.Xiaomi(@"imagen_dispositivos\Xiaomi\2.jpg", "Xiaomi Mi Note 3",
                                                "Tamaño \r\n" +
                                                "5.65 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 1920 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "401 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "12 Mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "16 Mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3500 mah\r\n\r\n" +
                                                "Autonomia de Conversación (3g)\r\n" +
                                                "34 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 660 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "6 gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 3:
                        try
                        {

                            dispositivos.Xiaomi(@"imagen_dispositivos\Xiaomi\3.jpg", "Xiaomi Redmi Note 5 Pro",
                                                "Tamaño \r\n" +
                                                "5.99 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 2160 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "403 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "12 Mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "20 Mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "4000 mah\r\n\r\n" +
                                                "Autonomia de Conversación (3g)\r\n" +
                                                "39 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 636 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "4 gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }

            if (marcaSelecionada == "BlackBerry")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {

                            dispositivos.BlackBerry(@"imagen_dispositivos\BlackBerry\0.jpg", "BlackBerry DTEK50",
                                                "Tamaño \r\n" +
                                                "5.2 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 1920 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "424 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "13 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "8 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "2610 mah\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "17 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 617 MSM8952 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "3 gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 1:
                        try
                        {

                            dispositivos.BlackBerry(@"imagen_dispositivos\BlackBerry\1.jpg", "BlackBerry KEYone",
                                                "Tamaño \r\n" +
                                                "4.2 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 1620 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "433 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "12 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "8 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3505 mah\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "17 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 625 MSM8953 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "3 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    case 2:
                        try
                        {

                            dispositivos.BlackBerry(@"imagen_dispositivos\BlackBerry\2.jpg", "BlackBerry Motion",
                                                "Tamaño \r\n" +
                                                "5.5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 1920 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "401 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "12 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "8 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "4000 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "17 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 625 MSM8953 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "4 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 3:
                        try
                        {

                            dispositivos.BlackBerry(@"imagen_dispositivos\BlackBerry\3.jpg", "BlackBerry Aurora",
                                                "Tamaño \r\n" +
                                                "5.5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "720 x 1280 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "267 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "13 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "8 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3000 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "20 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 425 MSM8917 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "4 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }

            if (marcaSelecionada == "Elephone")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {

                            dispositivos.Elephone(@"imagen_dispositivos\Elephone\0.jpg", "Elephone C1X",
                                                "Tamaño \r\n" +
                                                "5.5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "720 x 1280 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "257 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "8 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "5 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "2500 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "24 horas",
                                                "SoC \r\n" +
                                                "MediaTek MT6737 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "2 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 1:
                        try
                        {

                            dispositivos.Elephone(@"imagen_dispositivos\Elephone\1.jpg", "Elephone R9",
                                                "Tamaño \r\n" +
                                                "5.5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 1920 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "401 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "13 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "5 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3000 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "30 horas",
                                                "SoC \r\n" +
                                                "MediaTek Helio X20 (MT6797) \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "2 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    case 2:
                        try
                        {

                            dispositivos.Elephone(@"imagen_dispositivos\Elephone\2.jpg", "Elephone S7",
                                                "Tamaño \r\n" +
                                                "5.5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 1920 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "401 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "13 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "5 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3000 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "30 horas",
                                                "SoC \r\n" +
                                                "MediaTek Helio X20 (MT6797) \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "2 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 3:
                        try
                        {
                            dispositivos.Elephone(@"imagen_dispositivos\Elephone\3.jpg", "Elephone S3",
                                                "Tamaño \r\n" +
                                                "5.2 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 1920 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "424 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "13 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "1 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "2100 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "8 horas",
                                                "SoC \r\n" +
                                                "MediaTek MT6753 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "3 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }

            if (marcaSelecionada == "Google")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {

                            dispositivos.Google(@"imagen_dispositivos\Google\0.jpg", "Google Pixel",
                                                "Tamaño \r\n" +
                                                "5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 1920 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "441 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "12 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "8 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "2770 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "26 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 821 MSM8996 PRO \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "4 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 1:
                        try
                        {

                            dispositivos.Google(@"imagen_dispositivos\Google\1.jpg", "Google Pixel XL",
                                                "Tamaño \r\n" +
                                                "5.5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1440 x 2560 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "534 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "12 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "8 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3450 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "32 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 821 MSM8996 PRO \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "4 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    case 2:
                        try
                        {

                            dispositivos.Google(@"imagen_dispositivos\Google\0.jpg", "Google Pixel 2",
                                                "Tamaño \r\n" +
                                                "5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 1920 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "441 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "12 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "8 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "2770 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "26 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 835 MSM8996 PRO \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "4 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 3:
                        try
                        {

                            dispositivos.Google(@"imagen_dispositivos\Google\0.jpg", "Google Pixel 2 XL",
                                                "Tamaño \r\n" +
                                                "6 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1440 x 2880 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "537 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "12 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "8 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3520 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "26 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 835 MSM8998 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "4 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }

            if (marcaSelecionada == "HTC")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {

                            dispositivos.HTC(@"imagen_dispositivos\HTC\0.jpg", "HTC U11 EYEs",
                                                "Tamaño \r\n" +
                                                "6 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 2160 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "402 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "12 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "5 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3930 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "26 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 652 MSM8976 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "4 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 1:
                        try
                        {

                            dispositivos.HTC(@"imagen_dispositivos\HTC\1.jpg", "HTC Desire 10 Compact",
                                                "Tamaño \r\n" +
                                                "5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "720 x 1280 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "294 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "13 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "5 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3300 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "19 horas",
                                                "SoC \r\n" +
                                                "MediaTek MT6737T \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "3 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    case 2:
                        try
                        {

                            dispositivos.HTC(@"imagen_dispositivos\HTC\0.jpg", "HTC One X10",
                                                "Tamaño \r\n" +
                                                "5.5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 1920 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "401 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "16 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "8 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "4000 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "25 horas",
                                                "SoC \r\n" +
                                                "MediaTek Helio P10\r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "4 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 3:
                        try
                        {

                            dispositivos.HTC(@"imagen_dispositivos\HTC\0.jpg", "HTC U11",
                                                "Tamaño \r\n" +
                                                "5.5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1440 x 2560 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "534 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "12 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "16 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3000 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "24 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 835 MSM8998 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "4 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }

            if (marcaSelecionada == "Huawei")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {

                            dispositivos.Huawei(@"imagen_dispositivos\Huawei\0.jpg", "Huawei Mate 10",
                                                "Tamaño \r\n" +
                                                "5.9 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1440 x 2560 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "498 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "12 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "8 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "4000 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "25 horas",
                                                "SoC \r\n" +
                                                "Huawei HiSilicon KIRIN 97\r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "4 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 1:
                        try
                        {

                            dispositivos.Huawei(@"imagen_dispositivos\Huawei\1.jpg", "Huawei Mate 9 PRO",
                                                "Tamaño \r\n" +
                                                "5.5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1440 x 2560 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "534 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "12 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "8 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "4000 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "30 horas",
                                                "SoC \r\n" +
                                                "Huawei HiSilicon KIRIN 960 r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "4 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    case 2:
                        try
                        {

                            dispositivos.Huawei(@"imagen_dispositivos\Huawei\2.jpg", "Huawei Nova 3Gen",
                                                "Tamaño \r\n" +
                                                "5.8 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 2280 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "435 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "16 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "24 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3000 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "17 horas",
                                                "SoC \r\n" +
                                                "Huawei HiSilicon KIRIN 659 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "4 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 3:
                        try
                        {

                            dispositivos.Huawei(@"imagen_dispositivos\Huawei\3.jpg", "Huawei P20 PRO",
                                                "Tamaño \r\n" +
                                                "6.1 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 2240 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "408 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "10 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "24 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "4000 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "25 horas",
                                                "SoC \r\n" +
                                                "Huawei HiSilicon KIRIN 970\r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "6 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                }
            }

            if (marcaSelecionada == "LG")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {

                            dispositivos.LG(@"imagen_dispositivos\LG\0.jpg", "LG K8",
                                                "Tamaño \r\n" +
                                                "5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "720 x 1280 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "294 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "8 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "5 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "2500 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "7 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 210 MSM8909\r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "2 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 1:
                        try
                        {

                            dispositivos.LG(@"imagen_dispositivos\LG\1.jpg", "LG K10",
                                                "Tamaño \r\n" +
                                                "5.3 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "720 x 1280 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "277 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "13 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "8 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3000 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "17 horas",
                                                "SoC \r\n" +
                                                "MediaTek MT6750 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "2 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    case 2:
                        try
                        {

                            dispositivos.LG(@"imagen_dispositivos\LG\2.jpg", "LG V30S THNIQ",
                                                "Tamaño \r\n" +
                                                "6 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1440 x 2880 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "537 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "16 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "5 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3300 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "19 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 835 MSM8998\r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "6 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 3:
                        try
                        {

                            dispositivos.LG(@"imagen_dispositivos\LG\3.jpg", "LG Q6",
                                                "Tamaño \r\n" +
                                                "5.5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 2160 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "439 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "13 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "5 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3000 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "17 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 435 MSM8940 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "3 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }

            if (marcaSelecionada == "Microsoft")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {

                            dispositivos.Microsoft(@"imagen_dispositivos\Microsoft\0.jpg", "Microsoft Lumia 650",
                                                "Tamaño \r\n" +
                                                "5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "720 x 1280 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "294 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "8 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "5 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "2000 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "13 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 212 MSM8909 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "1 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 1:
                        try
                        {

                            dispositivos.Microsoft(@"imagen_dispositivos\Microsoft\1.jpg", "Microsoft Lumia 950 XL",
                                                "Tamaño \r\n" +
                                                "5.7 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1440 x 2560 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "515 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "20 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "5 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3340 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "19 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 810 MSM8994 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "3 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    case 2:
                        try
                        {

                            dispositivos.Microsoft(@"imagen_dispositivos\Microsoft\2.jpg", "Microsoft Lumia 640 XL",
                                                "Tamaño \r\n" +
                                                "5.7 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "720 x 1280 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "258 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "13 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "8 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3000 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "23 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 400 MSM8926 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "1 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 3:
                        try
                        {

                            dispositivos.Microsoft(@"imagen_dispositivos\Microsoft\3.jpg", "Microsoft Lumia 550",
                                                "Tamaño \r\n" +
                                                "4.7 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "720 x 1280 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "312 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "5 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "2 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "2100 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "14 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 210 MSM8909 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "1 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                }
            }

            if (marcaSelecionada == "Motorola")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {

                            dispositivos.Motorola(@"imagen_dispositivos\Motorola\0.jpg", "Motorola Moto C Plus",
                                                "Tamaño \r\n" +
                                                "5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "720 x 1280 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "294 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "8 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "2 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "4000 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "30 horas",
                                                "SoC \r\n" +
                                                "MediaTek MT6737 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "1 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 1:
                        try
                        {

                            dispositivos.Motorola(@"imagen_dispositivos\Motorola\1.jpg", "Motorola Moto Green Pomelo",
                                                "Tamaño \r\n" +
                                                "5.2 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 1920 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "424 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "16 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "16 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3000 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "18 horas",
                                                "SoC \r\n" +
                                                "Qualcomm SnapDragon 430 MSM8937 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "4 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    case 2:
                        try
                        {

                            dispositivos.Motorola(@"imagen_dispositivos\Motorola\2.jpg", "Motorola Z 2018",
                                                "Tamaño \r\n" +
                                                "5.5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1440 x 2560 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "534 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "12 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "5 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "2730 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "24 horas",
                                                "SoC \r\n" +
                                                "Qualcomm SnapDragon 835 MSM8998 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "6 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    case 3:
                        try
                        {

                            dispositivos.Motorola(@"imagen_dispositivos\Motorola\3.jpg", "Motorola G5s PLUS",
                                                "Tamaño \r\n" +
                                                "5.5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 1920 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "401 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "13 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "8 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3000 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "24 horas",
                                                "SoC \r\n" +
                                                "Qualcomm SnapDragon 625 MSM8953 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "3 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }

            if (marcaSelecionada == "Samsung")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {

                            dispositivos.Samsung(@"imagen_dispositivos\Samsung\0.jpg", "Samsung Galaxy S8 Active",
                                                "Tamaño \r\n" +
                                                "5.8 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1440 x 2960 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "558 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "12 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "8 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "4000 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "24 horas",
                                                "SoC \r\n" +
                                                "Qualcomm SnapDragon 835 MSM8996 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "4 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 1:
                        try
                        {

                            dispositivos.Samsung(@"imagen_dispositivos\Samsung\1.jpg", "Samsung Galaxy On7 Prime",
                                                "Tamaño \r\n" +
                                                "5.5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 1920 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "401 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "13 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "13 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3300 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "24 horas",
                                                "SoC \r\n" +
                                                "Samsung Exynos 7 Octa 7870 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "3 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    case 2:
                        try
                        {

                            dispositivos.Samsung(@"imagen_dispositivos\Samsung\2.jpg", "Samsung Galaxy S9",
                                                "Tamaño \r\n" +
                                                "5.8 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1440 x 2960 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "568 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "12 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "8 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3000 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "24 horas",
                                                "SoC \r\n" +
                                                "Samsung Exynos 9 9810 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "4 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    case 3:
                        try
                        {

                            dispositivos.Samsung(@"imagen_dispositivos\Samsung\3.jpg", "Samsung Galaxy j7 Core",
                                                "Tamaño \r\n" +
                                                "5.5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "720 x 1280 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "267 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "13 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "5 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3000 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "21 horas",
                                                "SoC \r\n" +
                                                "Samsung Exynos 7 Octa 7870 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "2 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }

            if (marcaSelecionada == "Sony")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {

                            dispositivos.Sony(@"imagen_dispositivos\Sony\0.jpg", "Sony Xperia XA2",
                                                "Tamaño \r\n" +
                                                "5.2 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 1920 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "424 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "23 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "8 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3300 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "24 horas",
                                                "SoC \r\n" +
                                                "Qualcomm Snapdragon 630 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "3 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 1:
                        try
                        {

                            dispositivos.Sony(@"imagen_dispositivos\Sony\1.jpg", "Sony Xperia L2",
                                                "Tamaño \r\n" +
                                                "5.5 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "720 x 1280 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "267 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "13 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "8 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3300 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "24 horas",
                                                "SoC \r\n" +
                                                "MediaTek MT6737T \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "3 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    case 2:
                        try
                        {

                            dispositivos.Sony(@"imagen_dispositivos\Sony\2.jpg", "Sony Xperia R1 PLUS",
                                                "Tamaño \r\n" +
                                                "5.2 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "720 x 1280 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "282 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "13 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "8 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "2620 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "24 horas",
                                                "SoC \r\n" +
                                                "Qualcomm SnapDragon 430 MSM8937 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "3 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 3:
                        try
                        {

                            dispositivos.Sony(@"imagen_dispositivos\Sony\3.jpg", "Sony Xperia XZ2",
                                                "Tamaño \r\n" +
                                                "5.7 pulgadas \r\n\r\n" +
                                                "Resolución \r\n" +
                                                "1080 x 2160 px \r\n\r\n" +
                                                "Densidad \r\n" +
                                                "424 ppi (pixeles por pulgada)",
                                                "Primaria \r\n" +
                                                "19 mp (4032 x 3024 px)\r\n\r\n" +
                                                "Secundaria\r\n" +
                                                "5 mp (3088 x 2320 px)",
                                                "Capacidad \r\n" +
                                                "3180 mAh\r\n\r\n" +
                                                "Autonomia de conversación (3g)\r\n" +
                                                "24 horas",
                                                "SoC \r\n" +
                                                "Qualcomm SnapDragon 845 \r\n\r\n" +
                                                "Memoria Ram\r\n" +
                                                "4 Gb");

                        }
                        catch (Exception v)
                        {
                            MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
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
