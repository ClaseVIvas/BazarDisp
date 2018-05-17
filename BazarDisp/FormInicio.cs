using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

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
        int oriX = 10;
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
                                lblCliente.Text = bazar.txtNombreCliente.Text;
                                lblCliente.TextAlign = ContentAlignment.MiddleCenter;
                                linkLblCopirig.Links.Add(0, 0, "https://decaracteristicas.com/");
                                lblCopirigh.Text = "Nota: \r\n Todas las imagenes utilizadas en éste programa han sido descargadas \r\n ";
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
            for (int i = 0; i < 12; i++)
            {
                if (i % numColumnas == 0)
                {
                    x = oriX;
                    y += separaciónVertical;
                }
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = tamañoImagenes;
                pictureBox.Location = new Point(x, y);
                pictureBox.Image = Image.FromFile(@"image_marcas\" + i + ".png");
                pictureBox.MouseClick += new MouseEventHandler(ClickBotonMarca);
                pictureBox.Tag = i;
                Controls.Add(pictureBox);
                x += separacionHorizontal;
            }
        }

        public void ClickBotonMarca(object sender, MouseEventArgs e)
        {
            PictureBox pctBox = sender as PictureBox;
            FrmSeleccionDispositivo frmSeleccionDispositivo = new FrmSeleccionDispositivo();
            int imagenSeleccionada = Convert.ToInt32(pctBox.Tag);
            switch (imagenSeleccionada)
            {
                case 0:
                    // APPLE
                    try
                    {
                        frmSeleccionDispositivo.lblSeleccionDisp.Text = "APPLE";
                        frmSeleccionDispositivo.CreadImagenesDispositivos("Apple");
                        frmSeleccionDispositivo.Show();
                    }
                    catch (IOException v)
                    {
                        MessageBox.Show("ERROR: "+ v.Message,"BAZAR DISP",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    break;
                case 1:
                    // XIAOMI
                    try
                    {
                        frmSeleccionDispositivo.lblSeleccionDisp.Text = "Xiaomi";
                        frmSeleccionDispositivo.CreadImagenesDispositivos("Xiaomi");
                        frmSeleccionDispositivo.Show();
                    }
                    catch (IOException v)
                    {
                        MessageBox.Show("ERROR: " + v.Message, "BAZAR DISP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 2:
                    //GOOGLE
                    frmSeleccionDispositivo.lblSeleccionDisp.Text = "Google";
                    frmSeleccionDispositivo.CreadImagenesDispositivos("Google");
                    frmSeleccionDispositivo.Show();

                    break;
                case 3:
                    // HUAWEI
                    frmSeleccionDispositivo.lblSeleccionDisp.Text = "Huawei";
                    frmSeleccionDispositivo.CreadImagenesDispositivos("Huawei");
                    frmSeleccionDispositivo.Show();

                    break;
                case 4:
                    // HTC
                    frmSeleccionDispositivo.lblSeleccionDisp.Text = "HTC";
                    frmSeleccionDispositivo.CreadImagenesDispositivos("HTC");
                    frmSeleccionDispositivo.Show();

                    break;
                case 5:
                    // SAMSUNG
                    frmSeleccionDispositivo.lblSeleccionDisp.Text = "Samsung";
                    frmSeleccionDispositivo.CreadImagenesDispositivos("Samsung");
                    frmSeleccionDispositivo.Show();

                    break;
                case 6:
                    // SONY
                    frmSeleccionDispositivo.lblSeleccionDisp.Text = "SONY";
                    frmSeleccionDispositivo.CreadImagenesDispositivos("Sony");
                    frmSeleccionDispositivo.Show();

                    break;
                case 7:
                    // LG
                    frmSeleccionDispositivo.lblSeleccionDisp.Text = "LG";
                    frmSeleccionDispositivo.CreadImagenesDispositivos("LG");
                    frmSeleccionDispositivo.Show();

                    break;
                case 8:
                    // ELEPHONE
                    frmSeleccionDispositivo.lblSeleccionDisp.Text = "Elephone";
                    frmSeleccionDispositivo.CreadImagenesDispositivos("Elephone");
                    frmSeleccionDispositivo.Show();

                    break;
                case 9:
                    //MICROSOFT
                    frmSeleccionDispositivo.lblSeleccionDisp.Text = "Microsoft";
                    frmSeleccionDispositivo.CreadImagenesDispositivos("Microsoft");
                    frmSeleccionDispositivo.Show();

                    break;
                case 10:
                    // BLACKBERRY
                    frmSeleccionDispositivo.lblSeleccionDisp.Text = "BlackBerry";
                    frmSeleccionDispositivo.CreadImagenesDispositivos("BlackBerry");
                    frmSeleccionDispositivo.Show();

                    break;
                case 11:
                    //MOTOROLA
                    frmSeleccionDispositivo.lblSeleccionDisp.Text = "Motorola";
                    frmSeleccionDispositivo.CreadImagenesDispositivos("Motorola");
                    frmSeleccionDispositivo.Show();

                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
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
