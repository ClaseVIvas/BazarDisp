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
            lbltextInfo.Text = "Estos Son Los Dispositivo Disponibles. \r\n Selecciona Alguno para ver sus Caracteristicas Basicas";
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

                            dispositivos.Xiaomi(@"imagen_dispositivos\Xiaomi\0.jpg", "iphone x",
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

            if (marcaSelecionada == "BlackBerry")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {

                            dispositivos.Xiaomi(@"imagen_dispositivos\BlackBerry\0.jpg", "iphone x",
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

            if (marcaSelecionada == "Elephone")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {
                            dispositivos.Xiaomi(@"imagen_dispositivos\Elephone\0.jpg", "iphone x",
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

            if (marcaSelecionada == "Google")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {
                            dispositivos.Xiaomi(@"imagen_dispositivos\Google\0.jpg", "iphone x",
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

            if (marcaSelecionada == "HTC")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {
                            dispositivos.Xiaomi(@"imagen_dispositivos\HTC\0.jpg", "iphone x",
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

            if (marcaSelecionada == "Huawei")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {
                            dispositivos.Xiaomi(@"imagen_dispositivos\Huawei\0.jpg", "iphone x",
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

            if (marcaSelecionada == "LG")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {
                            dispositivos.Xiaomi(@"imagen_dispositivos\LG\0.jpg", "iphone x",
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

            if (marcaSelecionada == "Microsoft")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {

                            dispositivos.Xiaomi(@"imagen_dispositivos\Microsoft\0.jpg", "iphone x",
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

            if (marcaSelecionada == "Motorola")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {
                            dispositivos.Xiaomi(@"imagen_dispositivos\Motorola\0.jpg", "iphone x",
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

            if (marcaSelecionada == "Samsung")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {
                            dispositivos.Xiaomi(@"imagen_dispositivos\Samsung\0.jpg", "iphone x",
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

            if (marcaSelecionada == "Sony")
            {
                switch (imagenSeleccionada)
                {
                    case 0:
                        try
                        {
                            dispositivos.Xiaomi(@"imagen_dispositivos\Sony\0.jpg", "iphone x",
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
        }

        public FrmDispositivos DispositivoSeleccionado(string img, string nombreD, string pantalla, string camara, string bateria, string sistema)
        {
            FrmDispositivos dispositivos = new FrmDispositivos(img, nombreD, pantalla, camara, bateria, sistema);
            dispositivos.Show();
            return dispositivos;
        }
    }
}
