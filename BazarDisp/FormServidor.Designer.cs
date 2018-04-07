﻿namespace BazarDisp
{
    partial class FormServidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServidor));
            this.btnListar = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbServidor = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblComandos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.AutoSize = true;
            this.btnListar.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(641, 297);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(148, 46);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Dispositivos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.PulsaComando);
            // 
            // btnPedido
            // 
            this.btnPedido.AutoSize = true;
            this.btnPedido.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.Location = new System.Drawing.Point(658, 349);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(114, 52);
            this.btnPedido.TabIndex = 2;
            this.btnPedido.Text = "Hacer Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(684, 407);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(62, 53);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.PulsaComando);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 89);
            this.label3.TabIndex = 5;
            this.label3.Text = "BazarDisp";
            // 
            // txtbServidor
            // 
            this.txtbServidor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbServidor.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtbServidor.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbServidor.Location = new System.Drawing.Point(0, 0);
            this.txtbServidor.Multiline = true;
            this.txtbServidor.Name = "txtbServidor";
            this.txtbServidor.ReadOnly = true;
            this.txtbServidor.Size = new System.Drawing.Size(513, 480);
            this.txtbServidor.TabIndex = 4;
            this.txtbServidor.Text = "SERVIDOR BAZARDISP - ACTIVO";
            this.txtbServidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIniciar
            // 
            this.btnIniciar.AutoSize = true;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(641, 138);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(149, 46);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "INICAR SERVIDOR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblComandos
            // 
            this.lblComandos.AutoSize = true;
            this.lblComandos.Font = new System.Drawing.Font("Script MT Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandos.Location = new System.Drawing.Point(623, 259);
            this.lblComandos.Name = "lblComandos";
            this.lblComandos.Size = new System.Drawing.Size(179, 24);
            this.lblComandos.TabIndex = 7;
            this.lblComandos.Text = "Comados del Servidor";
            // 
            // FormServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(911, 480);
            this.Controls.Add(this.lblComandos);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtbServidor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.btnListar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormServidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SERVIDOR BAZARDISP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbServidor;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblComandos;
    }
}