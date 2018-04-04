﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace BazarDisp
{
    public partial class FormInicio : Form
    {
        // DECLARACION DE VARIABLES
        FormBienvenida bazar;
        FormServidor serv;
        string rutaMarcas;
        DirectoryInfo imagenes_Marcas;
        int x, y;
        bool aceptar;


        // CODE
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            bazar = new FormBienvenida();
            aceptar = true;
            do
            {
                DialogResult resp = bazar.ShowDialog();
                switch (resp)
                {
                    case DialogResult.OK:
                        if (bazar.textBox1.Text == "")
                        {
                            aceptar = false;
                            MessageBox.Show("Introduce Un Nombre Porfavor", "BazarDisp.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            aceptar = true;
                            lblCliente.Text = "BIENVENIDO " + bazar.textBox1.Text;
                            CreadImagenes();
                        }
                        break;
                    case DialogResult.Cancel:
                        Close();
                        break;
                }
            } while (!aceptar);
        }

        public void CreadImagenes()
        {
            rutaMarcas = "image_marcas";
            imagenes_Marcas = new DirectoryInfo(rutaMarcas);
            x = 10;
            y = 0;

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
                if (i % 4 == 0)
                {
                    x = 5;
                    y += 139;
                }
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(200, 133);
                pictureBox.Location = new Point(x, y);
                Console.WriteLine(i + ".png");
                pictureBox.Image = Image.FromFile(@"image_marcas\" + i + ".png");
                // Controls.Add(pictureBox);
                panel1.Controls.Add(pictureBox);
                x += 208;
            }
        }

        private void btnIniciaServidor_Click(object sender, EventArgs e)
        {
            serv = new FormServidor();
            DialogResult resp;
            try
            {
                resp = serv.ShowDialog();
                switch (resp)
                {
                    case DialogResult.OK:

                        break;
                    case DialogResult.Cancel:
                        serv.Close();
                        break;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
