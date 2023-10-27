namespace StellarShip_Express.RegistrarPaquete
{
    partial class frmRegistrarPaquete
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
            this.panTitulo = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tlpRemitente = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoInterior = new CustomControls.RJControls.RJTextBox();
            this.txtNombre = new CustomControls.RJControls.RJTextBox();
            this.txtEmpresa = new CustomControls.RJControls.RJTextBox();
            this.txtDireccion = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rjComboBox1 = new CustomControls.RJComboBox();
            this.panTitulo.SuspendLayout();
            this.tlpRemitente.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTitulo
            // 
            this.panTitulo.Controls.Add(this.label10);
            this.panTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitulo.Location = new System.Drawing.Point(0, 0);
            this.panTitulo.Name = "panTitulo";
            this.panTitulo.Size = new System.Drawing.Size(840, 62);
            this.panTitulo.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(12, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 28);
            this.label10.TabIndex = 10;
            this.label10.Text = "Registrar Paquete";
            // 
            // tlpRemitente
            // 
            this.tlpRemitente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpRemitente.ColumnCount = 3;
            this.tlpRemitente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRemitente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRemitente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRemitente.Controls.Add(this.label3, 2, 0);
            this.tlpRemitente.Controls.Add(this.label2, 0, 0);
            this.tlpRemitente.Controls.Add(this.txtNoInterior, 2, 3);
            this.tlpRemitente.Controls.Add(this.txtNombre, 0, 1);
            this.tlpRemitente.Controls.Add(this.txtEmpresa, 2, 1);
            this.tlpRemitente.Controls.Add(this.txtDireccion, 0, 3);
            this.tlpRemitente.Controls.Add(this.label4, 0, 2);
            this.tlpRemitente.Controls.Add(this.label5, 2, 2);
            this.tlpRemitente.Location = new System.Drawing.Point(12, 116);
            this.tlpRemitente.Name = "tlpRemitente";
            this.tlpRemitente.RowCount = 4;
            this.tlpRemitente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRemitente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRemitente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRemitente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRemitente.Size = new System.Drawing.Size(816, 180);
            this.tlpRemitente.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(421, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Empresa (Opcional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre completo (nombre y apellido)";
            // 
            // txtNoInterior
            // 
            this.txtNoInterior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoInterior.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtNoInterior.BackColor = System.Drawing.SystemColors.Window;
            this.txtNoInterior.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNoInterior.BorderFocusColor = System.Drawing.SystemColors.HotTrack;
            this.txtNoInterior.BorderRadius = 5;
            this.txtNoInterior.BorderSize = 2;
            this.txtNoInterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNoInterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNoInterior.Location = new System.Drawing.Point(422, 114);
            this.txtNoInterior.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoInterior.Multiline = false;
            this.txtNoInterior.Name = "txtNoInterior";
            this.txtNoInterior.Padding = new System.Windows.Forms.Padding(20, 15, 15, 15);
            this.txtNoInterior.PasswordChar = false;
            this.txtNoInterior.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNoInterior.PlaceholderText = "Nº interior/Depto (opcional)";
            this.txtNoInterior.Size = new System.Drawing.Size(390, 51);
            this.txtNoInterior.TabIndex = 12;
            this.txtNoInterior.Texts = "";
            this.txtNoInterior.UnderlinedStyle = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNombre.BorderFocusColor = System.Drawing.SystemColors.HotTrack;
            this.txtNombre.BorderRadius = 5;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.Location = new System.Drawing.Point(4, 24);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(20, 15, 15, 15);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "Nombre completo (nombre y apellido)";
            this.txtNombre.Size = new System.Drawing.Size(390, 51);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = false;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmpresa.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmpresa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtEmpresa.BorderFocusColor = System.Drawing.SystemColors.HotTrack;
            this.txtEmpresa.BorderRadius = 5;
            this.txtEmpresa.BorderSize = 2;
            this.txtEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmpresa.Location = new System.Drawing.Point(422, 24);
            this.txtEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpresa.Multiline = false;
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Padding = new System.Windows.Forms.Padding(20, 15, 15, 15);
            this.txtEmpresa.PasswordChar = false;
            this.txtEmpresa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmpresa.PlaceholderText = "Empresa (Opcional)";
            this.txtEmpresa.Size = new System.Drawing.Size(390, 51);
            this.txtEmpresa.TabIndex = 1;
            this.txtEmpresa.Texts = "";
            this.txtEmpresa.UnderlinedStyle = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDireccion.BorderFocusColor = System.Drawing.SystemColors.HotTrack;
            this.txtDireccion.BorderRadius = 5;
            this.txtDireccion.BorderSize = 2;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDireccion.Location = new System.Drawing.Point(4, 114);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Padding = new System.Windows.Forms.Padding(20, 15, 15, 15);
            this.txtDireccion.PasswordChar = false;
            this.txtDireccion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDireccion.PlaceholderText = "Calle y número";
            this.txtDireccion.Size = new System.Drawing.Size(390, 51);
            this.txtDireccion.TabIndex = 2;
            this.txtDireccion.Texts = "";
            this.txtDireccion.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Calle y número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(421, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nº interior/Depto (opcional)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enviar desde";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.rjComboBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 302);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(816, 97);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rjComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.rjComboBox1.BorderSize = 1;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rjComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rjComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.rjComboBox1.Items.AddRange(new object[] {
            "Afganistán",
            "Albania",
            "Alemania",
            "Argentina",
            "Australia",
            "Austria",
            "Bélgica",
            "Brasil",
            "Canadá",
            "China",
            "Colombia",
            "Corea del Sur",
            "Dinamarca",
            "Egipto",
            "España",
            "Estados Unidos",
            "Francia",
            "Grecia",
            "India",
            "Irlanda",
            "Italia",
            "Japón",
            "México",
            "Noruega",
            "Países Bajos",
            "Perú",
            "Portugal",
            "Reino Unido",
            "Rusia",
            "Suecia",
            "",
            ""});
            this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.Location = new System.Drawing.Point(3, 3);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(150, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox1.SelectedValue = null;
            this.rjComboBox1.Size = new System.Drawing.Size(193, 37);
            this.rjComboBox1.TabIndex = 14;
            this.rjComboBox1.Texts = "";
            // 
            // frmRegistrarPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 564);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tlpRemitente);
            this.Controls.Add(this.panTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistrarPaquete";
            this.Text = "frmRegistrarPaquete";
            this.Resize += new System.EventHandler(this.frmRegistrarPaquete_Resize);
            this.panTitulo.ResumeLayout(false);
            this.panTitulo.PerformLayout();
            this.tlpRemitente.ResumeLayout(false);
            this.tlpRemitente.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTitulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tlpRemitente;
        private CustomControls.RJControls.RJTextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtEmpresa;
        private CustomControls.RJControls.RJTextBox txtDireccion;
        private CustomControls.RJControls.RJTextBox txtNoInterior;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomControls.RJComboBox rjComboBox1;
    }
}