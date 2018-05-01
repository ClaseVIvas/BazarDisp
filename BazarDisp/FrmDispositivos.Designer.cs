namespace BazarDisp
{
    partial class FrmDispositivos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDispositivos));
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCaracteristicas = new System.Windows.Forms.Label();
            this.pnlPantalla = new System.Windows.Forms.Panel();
            this.pctbPantalla = new System.Windows.Forms.PictureBox();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.pnlCamara = new System.Windows.Forms.Panel();
            this.pctbCamara = new System.Windows.Forms.PictureBox();
            this.txtCamara = new System.Windows.Forms.TextBox();
            this.pnlBateria = new System.Windows.Forms.Panel();
            this.pctbBateria = new System.Windows.Forms.PictureBox();
            this.txtBateria = new System.Windows.Forms.TextBox();
            this.pnlSistema = new System.Windows.Forms.Panel();
            this.pctbSistema = new System.Windows.Forms.PictureBox();
            this.txtSistema = new System.Windows.Forms.TextBox();
            this.pctbDispositivo = new System.Windows.Forms.PictureBox();
            this.pnlPantalla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPantalla)).BeginInit();
            this.pnlCamara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbCamara)).BeginInit();
            this.pnlBateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbBateria)).BeginInit();
            this.pnlSistema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbDispositivo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCliente.Font = new System.Drawing.Font("Rockwell", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(353, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(229, 40);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "DISPOSITIVO";
            // 
            // lblCaracteristicas
            // 
            this.lblCaracteristicas.AutoSize = true;
            this.lblCaracteristicas.Font = new System.Drawing.Font("Script MT Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracteristicas.Location = new System.Drawing.Point(495, 80);
            this.lblCaracteristicas.Name = "lblCaracteristicas";
            this.lblCaracteristicas.Size = new System.Drawing.Size(219, 24);
            this.lblCaracteristicas.TabIndex = 8;
            this.lblCaracteristicas.Text = "Características Principales";
            // 
            // pnlPantalla
            // 
            this.pnlPantalla.Controls.Add(this.pctbPantalla);
            this.pnlPantalla.Controls.Add(this.txtPantalla);
            this.pnlPantalla.Location = new System.Drawing.Point(367, 135);
            this.pnlPantalla.Name = "pnlPantalla";
            this.pnlPantalla.Size = new System.Drawing.Size(228, 157);
            this.pnlPantalla.TabIndex = 9;
            // 
            // pctbPantalla
            // 
            this.pctbPantalla.Image = ((System.Drawing.Image)(resources.GetObject("pctbPantalla.Image")));
            this.pctbPantalla.Location = new System.Drawing.Point(42, 5);
            this.pctbPantalla.Name = "pctbPantalla";
            this.pctbPantalla.Size = new System.Drawing.Size(24, 24);
            this.pctbPantalla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctbPantalla.TabIndex = 12;
            this.pctbPantalla.TabStop = false;
            // 
            // txtPantalla
            // 
            this.txtPantalla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPantalla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPantalla.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPantalla.Location = new System.Drawing.Point(69, 6);
            this.txtPantalla.Multiline = true;
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.ReadOnly = true;
            this.txtPantalla.Size = new System.Drawing.Size(107, 24);
            this.txtPantalla.TabIndex = 8;
            this.txtPantalla.Text = "PANTALLA";
            this.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlCamara
            // 
            this.pnlCamara.Controls.Add(this.pctbCamara);
            this.pnlCamara.Controls.Add(this.txtCamara);
            this.pnlCamara.Location = new System.Drawing.Point(642, 135);
            this.pnlCamara.Name = "pnlCamara";
            this.pnlCamara.Size = new System.Drawing.Size(228, 157);
            this.pnlCamara.TabIndex = 10;
            // 
            // pctbCamara
            // 
            this.pctbCamara.Image = ((System.Drawing.Image)(resources.GetObject("pctbCamara.Image")));
            this.pctbCamara.Location = new System.Drawing.Point(47, 5);
            this.pctbCamara.Name = "pctbCamara";
            this.pctbCamara.Size = new System.Drawing.Size(30, 24);
            this.pctbCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbCamara.TabIndex = 9;
            this.pctbCamara.TabStop = false;
            // 
            // txtCamara
            // 
            this.txtCamara.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCamara.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCamara.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCamara.Location = new System.Drawing.Point(73, 5);
            this.txtCamara.Multiline = true;
            this.txtCamara.Name = "txtCamara";
            this.txtCamara.ReadOnly = true;
            this.txtCamara.Size = new System.Drawing.Size(107, 24);
            this.txtCamara.TabIndex = 9;
            this.txtCamara.Text = "CAMARA";
            this.txtCamara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlBateria
            // 
            this.pnlBateria.Controls.Add(this.pctbBateria);
            this.pnlBateria.Controls.Add(this.txtBateria);
            this.pnlBateria.Location = new System.Drawing.Point(367, 340);
            this.pnlBateria.Name = "pnlBateria";
            this.pnlBateria.Size = new System.Drawing.Size(228, 157);
            this.pnlBateria.TabIndex = 11;
            // 
            // pctbBateria
            // 
            this.pctbBateria.Image = ((System.Drawing.Image)(resources.GetObject("pctbBateria.Image")));
            this.pctbBateria.Location = new System.Drawing.Point(43, 3);
            this.pctbBateria.Name = "pctbBateria";
            this.pctbBateria.Size = new System.Drawing.Size(26, 30);
            this.pctbBateria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbBateria.TabIndex = 12;
            this.pctbBateria.TabStop = false;
            // 
            // txtBateria
            // 
            this.txtBateria.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBateria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBateria.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBateria.Location = new System.Drawing.Point(62, 6);
            this.txtBateria.Multiline = true;
            this.txtBateria.Name = "txtBateria";
            this.txtBateria.ReadOnly = true;
            this.txtBateria.Size = new System.Drawing.Size(107, 24);
            this.txtBateria.TabIndex = 9;
            this.txtBateria.Text = "BATERÍA";
            this.txtBateria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlSistema
            // 
            this.pnlSistema.Controls.Add(this.pctbSistema);
            this.pnlSistema.Controls.Add(this.txtSistema);
            this.pnlSistema.Location = new System.Drawing.Point(642, 340);
            this.pnlSistema.Name = "pnlSistema";
            this.pnlSistema.Size = new System.Drawing.Size(228, 157);
            this.pnlSistema.TabIndex = 12;
            // 
            // pctbSistema
            // 
            this.pctbSistema.Image = ((System.Drawing.Image)(resources.GetObject("pctbSistema.Image")));
            this.pctbSistema.Location = new System.Drawing.Point(53, 3);
            this.pctbSistema.Name = "pctbSistema";
            this.pctbSistema.Size = new System.Drawing.Size(24, 24);
            this.pctbSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctbSistema.TabIndex = 11;
            this.pctbSistema.TabStop = false;
            // 
            // txtSistema
            // 
            this.txtSistema.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSistema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSistema.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSistema.Location = new System.Drawing.Point(73, 4);
            this.txtSistema.Multiline = true;
            this.txtSistema.Name = "txtSistema";
            this.txtSistema.ReadOnly = true;
            this.txtSistema.Size = new System.Drawing.Size(107, 24);
            this.txtSistema.TabIndex = 9;
            this.txtSistema.Text = "SISTEMA";
            this.txtSistema.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pctbDispositivo
            // 
            this.pctbDispositivo.Location = new System.Drawing.Point(23, 80);
            this.pctbDispositivo.Name = "pctbDispositivo";
            this.pctbDispositivo.Size = new System.Drawing.Size(304, 417);
            this.pctbDispositivo.TabIndex = 0;
            this.pctbDispositivo.TabStop = false;
            // 
            // FrmDispositivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(921, 525);
            this.Controls.Add(this.pnlSistema);
            this.Controls.Add(this.pnlBateria);
            this.Controls.Add(this.pnlCamara);
            this.Controls.Add(this.pnlPantalla);
            this.Controls.Add(this.lblCaracteristicas);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.pctbDispositivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDispositivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDispositivos";
            this.pnlPantalla.ResumeLayout(false);
            this.pnlPantalla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPantalla)).EndInit();
            this.pnlCamara.ResumeLayout(false);
            this.pnlCamara.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbCamara)).EndInit();
            this.pnlBateria.ResumeLayout(false);
            this.pnlBateria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbBateria)).EndInit();
            this.pnlSistema.ResumeLayout(false);
            this.pnlSistema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbDispositivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctbDispositivo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCaracteristicas;
        private System.Windows.Forms.Panel pnlPantalla;
        private System.Windows.Forms.Panel pnlCamara;
        private System.Windows.Forms.Panel pnlBateria;
        private System.Windows.Forms.Panel pnlSistema;
        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.TextBox txtCamara;
        private System.Windows.Forms.TextBox txtBateria;
        private System.Windows.Forms.TextBox txtSistema;
        private System.Windows.Forms.PictureBox pctbCamara;
        private System.Windows.Forms.PictureBox pctbBateria;
        private System.Windows.Forms.PictureBox pctbSistema;
        private System.Windows.Forms.PictureBox pctbPantalla;
    }
}