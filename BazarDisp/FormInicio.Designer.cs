﻿namespace BazarDisp
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
            this.pnlImagenes = new System.Windows.Forms.Panel();
            this.txtExplicacion = new System.Windows.Forms.TextBox();
            this.pnlServidor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(582, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(92, 22);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "CLIENTE";
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
            this.pnlServidor.Location = new System.Drawing.Point(923, 623);
            this.pnlServidor.Name = "pnlServidor";
            this.pnlServidor.Size = new System.Drawing.Size(317, 90);
            this.pnlServidor.TabIndex = 4;
            // 
            // pnlImagenes
            // 
            this.pnlImagenes.AutoScroll = true;
            this.pnlImagenes.AutoSize = true;
            this.pnlImagenes.Location = new System.Drawing.Point(3, 59);
            this.pnlImagenes.Name = "pnlImagenes";
            this.pnlImagenes.Size = new System.Drawing.Size(816, 654);
            this.pnlImagenes.TabIndex = 5;
            // 
            // txtExplicacion
            // 
            this.txtExplicacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtExplicacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExplicacion.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExplicacion.Location = new System.Drawing.Point(841, 72);
            this.txtExplicacion.Multiline = true;
            this.txtExplicacion.Name = "txtExplicacion";
            this.txtExplicacion.ReadOnly = true;
            this.txtExplicacion.Size = new System.Drawing.Size(399, 355);
            this.txtExplicacion.TabIndex = 7;
            this.txtExplicacion.Text = resources.GetString("txtExplicacion.Text");
            this.txtExplicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1252, 719);
            this.Controls.Add(this.txtExplicacion);
            this.Controls.Add(this.pnlImagenes);
            this.Controls.Add(this.pnlServidor);
            this.Controls.Add(this.lblCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAZARDISP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Panel pnlImagenes;
        private System.Windows.Forms.TextBox txtExplicacion;
    }
}

