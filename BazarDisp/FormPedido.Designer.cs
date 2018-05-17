namespace BazarDisp
{
    partial class FormPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedido));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmBTamaño = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmBMarca = new System.Windows.Forms.ComboBox();
            this.cmBColor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(829, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "REALICE SU PEDIDO AÑADIENDO LA SIGUIENTE INFORMACIÓN";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "NOMBRE";
            // 
            // cmBTamaño
            // 
            this.cmBTamaño.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmBTamaño.FormattingEnabled = true;
            this.cmBTamaño.Items.AddRange(new object[] {
            "Normal",
            "Grande",
            "Pequeño"});
            this.cmBTamaño.Location = new System.Drawing.Point(608, 135);
            this.cmBTamaño.Name = "cmBTamaño";
            this.cmBTamaño.Size = new System.Drawing.Size(121, 21);
            this.cmBTamaño.TabIndex = 3;
            this.cmBTamaño.Text = "Tamaño";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(269, 219);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 43);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(470, 219);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 43);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cmBMarca
            // 
            this.cmBMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmBMarca.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmBMarca.FormattingEnabled = true;
            this.cmBMarca.Items.AddRange(new object[] {
            "Apple",
            "BlackBerry",
            "Elephone",
            "Google",
            "HTC",
            "Huawei",
            "LG",
            "Microsoft",
            "Motorola",
            "Samsung",
            "Sony",
            "Xiaomi"});
            this.cmBMarca.Location = new System.Drawing.Point(258, 135);
            this.cmBMarca.Name = "cmBMarca";
            this.cmBMarca.Size = new System.Drawing.Size(121, 21);
            this.cmBMarca.TabIndex = 7;
            // 
            // cmBColor
            // 
            this.cmBColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmBColor.FormattingEnabled = true;
            this.cmBColor.Items.AddRange(new object[] {
            "Negro",
            "Blanco",
            "Gris"});
            this.cmBColor.Location = new System.Drawing.Point(436, 134);
            this.cmBColor.Name = "cmBColor";
            this.cmBColor.Size = new System.Drawing.Size(121, 21);
            this.cmBColor.TabIndex = 8;
            this.cmBColor.Text = "COLOR";
            // 
            // FormPedido
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(905, 315);
            this.Controls.Add(this.cmBColor);
            this.Controls.Add(this.cmBMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmBTamaño);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PEDIDO PARA BAZAR DISP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ComboBox cmBTamaño;
        public System.Windows.Forms.ComboBox cmBMarca;
        public System.Windows.Forms.ComboBox cmBColor;
    }
}