namespace StellarShip_Express.Vehiculos
{
    partial class frmRegistrarVehiculo
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
            this.TitleBar = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinum = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new CustomControls.RButton();
            this.btnAceptar = new CustomControls.RButton();
            this.txtModelo = new CustomControls.RJControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblConductor = new System.Windows.Forms.Label();
            this.txtYear = new CustomControls.RJControls.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoPlaca = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoV = new System.Windows.Forms.Label();
            this.cmbConductor = new CustomControls.RJComboBox();
            this.txtTipo = new CustomControls.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDMod = new System.Windows.Forms.TextBox();
            this.TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(48)))), ((int)(((byte)(247)))));
            this.TitleBar.Controls.Add(this.lblTitulo);
            this.TitleBar.Controls.Add(this.btnMinum);
            this.TitleBar.Controls.Add(this.btnClose);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(412, 42);
            this.TitleBar.TabIndex = 26;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Enabled = false;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(3, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(166, 19);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Registro de Vehiculo";
            // 
            // btnMinum
            // 
            this.btnMinum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinum.FlatAppearance.BorderSize = 0;
            this.btnMinum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinum.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinum.IconColor = System.Drawing.Color.White;
            this.btnMinum.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinum.IconSize = 25;
            this.btnMinum.Location = new System.Drawing.Point(332, 4);
            this.btnMinum.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinum.Name = "btnMinum";
            this.btnMinum.Size = new System.Drawing.Size(36, 25);
            this.btnMinum.TabIndex = 4;
            this.btnMinum.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 18;
            this.btnClose.Location = new System.Drawing.Point(372, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(69)))), ((int)(((byte)(72)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(69)))), ((int)(((byte)(72)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 5;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(36, 447);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 40);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(139)))), ((int)(((byte)(99)))));
            this.btnAceptar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(139)))), ((int)(((byte)(99)))));
            this.btnAceptar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAceptar.BorderRadius = 5;
            this.btnAceptar.BorderSize = 0;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(234, 447);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 40);
            this.btnAceptar.TabIndex = 39;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.SystemColors.Window;
            this.txtModelo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtModelo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtModelo.BorderRadius = 0;
            this.txtModelo.BorderSize = 2;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtModelo.Location = new System.Drawing.Point(118, 175);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelo.Multiline = false;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtModelo.PasswordChar = false;
            this.txtModelo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtModelo.PlaceholderText = "";
            this.txtModelo.Size = new System.Drawing.Size(250, 31);
            this.txtModelo.TabIndex = 36;
            this.txtModelo.Texts = "";
            this.txtModelo.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(17, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Modelo";
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblConductor.Location = new System.Drawing.Point(17, 403);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(87, 18);
            this.lblConductor.TabIndex = 33;
            this.lblConductor.Text = "Conductor";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.SystemColors.Window;
            this.txtYear.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtYear.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtYear.BorderRadius = 0;
            this.txtYear.BorderSize = 2;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtYear.Location = new System.Drawing.Point(118, 335);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Multiline = false;
            this.txtYear.Name = "txtYear";
            this.txtYear.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtYear.PasswordChar = false;
            this.txtYear.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtYear.PlaceholderText = "";
            this.txtYear.Size = new System.Drawing.Size(250, 31);
            this.txtYear.TabIndex = 32;
            this.txtYear.Texts = "";
            this.txtYear.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(17, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "Año";
            // 
            // txtNoPlaca
            // 
            this.txtNoPlaca.BackColor = System.Drawing.SystemColors.Window;
            this.txtNoPlaca.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNoPlaca.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNoPlaca.BorderRadius = 0;
            this.txtNoPlaca.BorderSize = 2;
            this.txtNoPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoPlaca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNoPlaca.Location = new System.Drawing.Point(118, 227);
            this.txtNoPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoPlaca.Multiline = false;
            this.txtNoPlaca.Name = "txtNoPlaca";
            this.txtNoPlaca.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNoPlaca.PasswordChar = false;
            this.txtNoPlaca.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNoPlaca.PlaceholderText = "";
            this.txtNoPlaca.Size = new System.Drawing.Size(250, 31);
            this.txtNoPlaca.TabIndex = 30;
            this.txtNoPlaca.Texts = "";
            this.txtNoPlaca.UnderlinedStyle = false;
            this.txtNoPlaca._TextChanged += new System.EventHandler(this.txtNoPlaca__TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "No. Placa";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.SystemColors.Window;
            this.txtMarca.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMarca.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMarca.BorderRadius = 0;
            this.txtMarca.BorderSize = 2;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMarca.Location = new System.Drawing.Point(118, 123);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Multiline = false;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMarca.PasswordChar = false;
            this.txtMarca.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMarca.PlaceholderText = "";
            this.txtMarca.Size = new System.Drawing.Size(250, 31);
            this.txtMarca.TabIndex = 28;
            this.txtMarca.Texts = "";
            this.txtMarca.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Marca";
            // 
            // txtTipoV
            // 
            this.txtTipoV.AutoSize = true;
            this.txtTipoV.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.txtTipoV.Location = new System.Drawing.Point(17, 280);
            this.txtTipoV.Name = "txtTipoV";
            this.txtTipoV.Size = new System.Drawing.Size(72, 36);
            this.txtTipoV.TabIndex = 37;
            this.txtTipoV.Text = "Tipo de \r\nvehículo";
            // 
            // cmbConductor
            // 
            this.cmbConductor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbConductor.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbConductor.BorderSize = 1;
            this.cmbConductor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbConductor.ForeColor = System.Drawing.Color.DimGray;
            this.cmbConductor.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbConductor.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbConductor.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbConductor.Location = new System.Drawing.Point(118, 391);
            this.cmbConductor.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbConductor.Name = "cmbConductor";
            this.cmbConductor.Padding = new System.Windows.Forms.Padding(1);
            this.cmbConductor.SelectedValue = null;
            this.cmbConductor.Size = new System.Drawing.Size(250, 30);
            this.cmbConductor.TabIndex = 41;
            this.cmbConductor.Texts = "";
            this.cmbConductor.OnSelectedIndexChanged += new System.EventHandler(this.cmbConductor_OnSelectedIndexChanged);
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTipo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTipo.BorderRadius = 0;
            this.txtTipo.BorderSize = 2;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipo.Location = new System.Drawing.Point(118, 285);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo.Multiline = false;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTipo.PasswordChar = false;
            this.txtTipo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTipo.PlaceholderText = "";
            this.txtTipo.Size = new System.Drawing.Size(250, 31);
            this.txtTipo.TabIndex = 42;
            this.txtTipo.Texts = "";
            this.txtTipo.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(17, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "ID";
            // 
            // txtIDMod
            // 
            this.txtIDMod.Location = new System.Drawing.Point(118, 70);
            this.txtIDMod.Multiline = true;
            this.txtIDMod.Name = "txtIDMod";
            this.txtIDMod.Size = new System.Drawing.Size(250, 32);
            this.txtIDMod.TabIndex = 44;
            // 
            // frmRegistrarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 499);
            this.Controls.Add(this.txtIDMod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.cmbConductor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTipoV);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblConductor);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNoPlaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleBar);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistrarVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistrarVehiculo";
            this.Load += new System.EventHandler(this.frmRegistrarVehiculo_Load);
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnMinum;
        private FontAwesome.Sharp.IconButton btnClose;
        private CustomControls.RButton btnCancelar;
        private CustomControls.RButton btnAceptar;
        private CustomControls.RJControls.RJTextBox txtModelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblConductor;
        private CustomControls.RJControls.RJTextBox txtYear;
        private System.Windows.Forms.Label label7;
        private CustomControls.RJControls.RJTextBox txtNoPlaca;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox txtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTipoV;
        private CustomControls.RJComboBox cmbConductor;
        private CustomControls.RJControls.RJTextBox txtTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDMod;
    }
}