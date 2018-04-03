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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlServidor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCliente.Font = new System.Drawing.Font("Rockwell", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(364, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(519, 54);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "BIENVENIDO CLIENTE";
            // 
            // btnIniciaServidor
            // 
            this.btnIniciaServidor.AutoSize = true;
            this.btnIniciaServidor.Location = new System.Drawing.Point(95, 43);
            this.btnIniciaServidor.Name = "btnIniciaServidor";
            this.btnIniciaServidor.Size = new System.Drawing.Size(117, 42);
            this.btnIniciaServidor.TabIndex = 2;
            this.btnIniciaServidor.Text = "INICIA SERVIDOR";
            this.btnIniciaServidor.UseVisualStyleBackColor = true;
            this.btnIniciaServidor.Click += new System.EventHandler(this.btnIniciaServidor_Click);
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.Location = new System.Drawing.Point(3, 0);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(50, 17);
            this.lblAyuda.TabIndex = 3;
            this.lblAyuda.Text = "Ayuda";
            this.lblAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlServidor
            // 
            this.pnlServidor.AutoSize = true;
            this.pnlServidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlServidor.Controls.Add(this.btnIniciaServidor);
            this.pnlServidor.Controls.Add(this.lblAyuda);
            this.pnlServidor.Location = new System.Drawing.Point(864, 453);
            this.pnlServidor.Name = "pnlServidor";
            this.pnlServidor.Size = new System.Drawing.Size(317, 90);
            this.pnlServidor.TabIndex = 4;
            // 
            // txtExplicacion
            // 
            this.txtExplicacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtExplicacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExplicacion.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExplicacion.Location = new System.Drawing.Point(841, 92);
            this.txtExplicacion.Multiline = true;
            this.txtExplicacion.Name = "txtExplicacion";
            this.txtExplicacion.ReadOnly = true;
            this.txtExplicacion.Size = new System.Drawing.Size(383, 355);
            this.txtExplicacion.TabIndex = 7;
            this.txtExplicacion.Text = resources.GetString("txtExplicacion.Text");
            this.txtExplicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 345);
            this.panel1.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(348, 267);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 75);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 75);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 75);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1238, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtExplicacion);
            this.Controls.Add(this.pnlServidor);
            this.Controls.Add(this.lblCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAZARDISP";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.pnlServidor.ResumeLayout(false);
            this.pnlServidor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnIniciaServidor;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.Panel pnlServidor;
        private System.Windows.Forms.TextBox txtExplicacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

