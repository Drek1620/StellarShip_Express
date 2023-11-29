namespace StellarShip_Express
{
    partial class CuadroPaquete
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCambiar = new CustomControls.RButton();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cmbEstatus = new System.Windows.Forms.ComboBox();
			this.rButton1 = new CustomControls.RButton();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gainsboro;
			this.panel1.Controls.Add(this.btnCambiar);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.cmbEstatus);
			this.panel1.Controls.Add(this.rButton1);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(5, 7);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(310, 344);
			this.panel1.TabIndex = 15;
			// 
			// btnCambiar
			// 
			this.btnCambiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(229)))));
			this.btnCambiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(229)))));
			this.btnCambiar.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnCambiar.BorderRadius = 5;
			this.btnCambiar.BorderSize = 0;
			this.btnCambiar.FlatAppearance.BorderSize = 0;
			this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCambiar.ForeColor = System.Drawing.Color.White;
			this.btnCambiar.Location = new System.Drawing.Point(16, 305);
			this.btnCambiar.Name = "btnCambiar";
			this.btnCambiar.Size = new System.Drawing.Size(81, 28);
			this.btnCambiar.TabIndex = 29;
			this.btnCambiar.Text = "Cambiar";
			this.btnCambiar.TextColor = System.Drawing.Color.White;
			this.btnCambiar.UseVisualStyleBackColor = false;
			this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Lohit Telugu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(12, 151);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(108, 22);
			this.label11.TabIndex = 28;
			this.label11.Text = "Cambiar status:";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(136, 255);
			this.label9.Name = "label9";
			this.label9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.label9.Size = new System.Drawing.Size(160, 47);
			this.label9.TabIndex = 27;
			this.label9.Text = "El paquete ha llegado a un centro de clasificación";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Lohit Telugu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(136, 233);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(61, 22);
			this.label10.TabIndex = 26;
			this.label10.Text = "Detalles";
			// 
			// cmbEstatus
			// 
			this.cmbEstatus.BackColor = System.Drawing.Color.White;
			this.cmbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEstatus.FormattingEnabled = true;
			this.cmbEstatus.Items.AddRange(new object[] {
            "Recogido",
            "En Tránsito",
            "En Centro de Clasificación",
            "Listo para Entrega",
            "Intento de Entrega Fallido",
            "En Almacén/Depósito"});
			this.cmbEstatus.Location = new System.Drawing.Point(16, 176);
			this.cmbEstatus.Name = "cmbEstatus";
			this.cmbEstatus.Size = new System.Drawing.Size(101, 21);
			this.cmbEstatus.TabIndex = 25;
			// 
			// rButton1
			// 
			this.rButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.rButton1.BackColor = System.Drawing.Color.YellowGreen;
			this.rButton1.BackgroundColor = System.Drawing.Color.YellowGreen;
			this.rButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.rButton1.BorderRadius = 5;
			this.rButton1.BorderSize = 0;
			this.rButton1.FlatAppearance.BorderSize = 0;
			this.rButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rButton1.ForeColor = System.Drawing.Color.White;
			this.rButton1.Location = new System.Drawing.Point(215, 305);
			this.rButton1.Name = "rButton1";
			this.rButton1.Size = new System.Drawing.Size(81, 28);
			this.rButton1.TabIndex = 24;
			this.rButton1.Text = "Entregado";
			this.rButton1.TextColor = System.Drawing.Color.White;
			this.rButton1.UseVisualStyleBackColor = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Lohit Telugu", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(136, 207);
			this.label7.Name = "label7";
			this.label7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.label7.Size = new System.Drawing.Size(99, 26);
			this.label7.TabIndex = 23;
			this.label7.Text = "En Transito.";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Lohit Telugu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(136, 185);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 22);
			this.label8.TabIndex = 22;
			this.label8.Text = "Estatus";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Lohit Telugu", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(136, 137);
			this.label5.Name = "label5";
			this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.label5.Size = new System.Drawing.Size(160, 48);
			this.label5.TabIndex = 21;
			this.label5.Text = "Gomez Palacio\r\nDurango, Mexico.";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Lohit Telugu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(136, 115);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 22);
			this.label6.TabIndex = 20;
			this.label6.Text = "Destino";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(136, 82);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.label3.Size = new System.Drawing.Size(160, 48);
			this.label3.TabIndex = 19;
			this.label3.Text = "Alan Garcia";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Lohit Telugu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(136, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 22);
			this.label4.TabIndex = 18;
			this.label4.Text = "Recibe";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Lohit Telugu", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(136, 34);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.label2.Size = new System.Drawing.Size(172, 26);
			this.label2.TabIndex = 17;
			this.label2.Text = "000000000000000000";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lohit Telugu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(136, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 22);
			this.label1.TabIndex = 16;
			this.label1.Text = "Codigo de Seguimiento.";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(3, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(127, 118);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// CuadroPaquete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "CuadroPaquete";
			this.Size = new System.Drawing.Size(320, 357);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cmbEstatus;
		private CustomControls.RButton rButton1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		public CustomControls.RButton btnCambiar;
	}
}