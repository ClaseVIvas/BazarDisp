namespace BazarDisp
{
    partial class FrmSeleccionDispositivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccionDispositivo));
            this.lblSeleccionDisp = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbltextInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSeleccionDisp
            // 
            this.lblSeleccionDisp.AutoSize = true;
            this.lblSeleccionDisp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeleccionDisp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSeleccionDisp.Font = new System.Drawing.Font("Rockwell", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionDisp.Location = new System.Drawing.Point(195, 9);
            this.lblSeleccionDisp.Name = "lblSeleccionDisp";
            this.lblSeleccionDisp.Size = new System.Drawing.Size(211, 40);
            this.lblSeleccionDisp.TabIndex = 3;
            this.lblSeleccionDisp.Text = "SELECCION";
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Rockwell", 15F);
            this.btnSalir.Location = new System.Drawing.Point(227, 426);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 34);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbltextInfo
            // 
            this.lbltextInfo.AutoSize = true;
            this.lbltextInfo.Font = new System.Drawing.Font("Rockwell", 15F);
            this.lbltextInfo.Location = new System.Drawing.Point(6, 60);
            this.lbltextInfo.Name = "lbltextInfo";
            this.lbltextInfo.Size = new System.Drawing.Size(44, 22);
            this.lbltextInfo.TabIndex = 15;
            this.lbltextInfo.Text = "text";
            this.lbltextInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSeleccionDispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 472);
            this.Controls.Add(this.lbltextInfo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblSeleccionDisp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSeleccionDispositivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion Dispositivos";
            this.Load += new System.EventHandler(this.FrmSeleccionDispositivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lbltextInfo;
        public System.Windows.Forms.Label lblSeleccionDisp;
    }
}