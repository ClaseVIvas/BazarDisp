namespace BazarDisp
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnIniciaServidor = new System.Windows.Forms.Button();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.pnlServidor = new System.Windows.Forms.Panel();
            this.txtExplicacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCopirigh = new System.Windows.Forms.Label();
            this.linkLblCopirig = new System.Windows.Forms.LinkLabel();
            this.pnlServidor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCliente.Font = new System.Drawing.Font("Rockwell", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(977, 129);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(151, 39);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "CLIENTE";
            // 
            // btnIniciaServidor
            // 
            this.btnIniciaServidor.AutoSize = true;
            this.btnIniciaServidor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciaServidor.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciaServidor.Location = new System.Drawing.Point(95, 43);
            this.btnIniciaServidor.Name = "btnIniciaServidor";
            this.btnIniciaServidor.Size = new System.Drawing.Size(117, 42);
            this.btnIniciaServidor.TabIndex = 2;
            this.btnIniciaServidor.Text = "FABRICACIÓN";
            this.btnIniciaServidor.UseVisualStyleBackColor = true;
            this.btnIniciaServidor.Click += new System.EventHandler(this.btnIniciaServidor_Click);
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.Location = new System.Drawing.Point(3, 0);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(89, 17);
            this.lblAyuda.TabIndex = 3;
            this.lblAyuda.Text = "Fabrica DISP";
            this.lblAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlServidor
            // 
            this.pnlServidor.AutoSize = true;
            this.pnlServidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlServidor.Controls.Add(this.btnIniciaServidor);
            this.pnlServidor.Controls.Add(this.lblAyuda);
            this.pnlServidor.Location = new System.Drawing.Point(886, 402);
            this.pnlServidor.Name = "pnlServidor";
            this.pnlServidor.Size = new System.Drawing.Size(317, 90);
            this.pnlServidor.TabIndex = 4;
            // 
            // txtExplicacion
            // 
            this.txtExplicacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtExplicacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExplicacion.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExplicacion.Location = new System.Drawing.Point(859, 185);
            this.txtExplicacion.Multiline = true;
            this.txtExplicacion.Name = "txtExplicacion";
            this.txtExplicacion.ReadOnly = true;
            this.txtExplicacion.Size = new System.Drawing.Size(383, 182);
            this.txtExplicacion.TabIndex = 7;
            this.txtExplicacion.Text = resources.GetString("txtExplicacion.Text");
            this.txtExplicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1141, 88);
            this.label1.TabIndex = 8;
            this.label1.Text = "Principales Marcas A Su Disposición";
            // 
            // lblCopirigh
            // 
            this.lblCopirigh.AutoSize = true;
            this.lblCopirigh.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopirigh.Location = new System.Drawing.Point(844, 495);
            this.lblCopirigh.Name = "lblCopirigh";
            this.lblCopirigh.Size = new System.Drawing.Size(36, 13);
            this.lblCopirigh.TabIndex = 9;
            this.lblCopirigh.Text = "Nota: ";
            this.lblCopirigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLblCopirig
            // 
            this.linkLblCopirig.AutoSize = true;
            this.linkLblCopirig.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblCopirig.Location = new System.Drawing.Point(1007, 523);
            this.linkLblCopirig.Name = "linkLblCopirig";
            this.linkLblCopirig.Size = new System.Drawing.Size(34, 13);
            this.linkLblCopirig.TabIndex = 10;
            this.linkLblCopirig.TabStop = true;
            this.linkLblCopirig.Text = "AQUI";
            this.linkLblCopirig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormInicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1252, 560);
            this.Controls.Add(this.linkLblCopirig);
            this.Controls.Add(this.lblCopirigh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExplicacion);
            this.Controls.Add(this.pnlServidor);
            this.Controls.Add(this.lblCliente);
            this.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAZARDISP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInicio_FormClosing);
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.pnlServidor.ResumeLayout(false);
            this.pnlServidor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnIniciaServidor;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.Panel pnlServidor;
        private System.Windows.Forms.TextBox txtExplicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCopirigh;
        private System.Windows.Forms.LinkLabel linkLblCopirig;
    }
}

