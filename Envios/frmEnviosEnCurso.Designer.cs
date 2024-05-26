namespace StellarShip_Express.Envios
{
	partial class frmEnviosEnCurso
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtBusqueda = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rjComboBox1 = new CustomControls.RJComboBox();
            this.cmbFiltros = new CustomControls.RJComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbUnidades = new CustomControls.RJComboBox();
            this.cmbCambios = new CustomControls.RJComboBox();
            this.cmbEstado = new CustomControls.RJComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 108);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(940, 407);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.SizeChanged += new System.EventHandler(this.flowLayoutPanel1_SizeChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            this.btnActualizar.IconColor = System.Drawing.Color.White;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 25;
            this.btnActualizar.Location = new System.Drawing.Point(290, 44);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(44, 31);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(246, 44);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(44, 31);
            this.iconButton1.TabIndex = 18;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.txtBusqueda.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBusqueda.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBusqueda.BorderRadius = 0;
            this.txtBusqueda.BorderSize = 2;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBusqueda.Location = new System.Drawing.Point(15, 44);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(5);
            this.txtBusqueda.MaxLength = 32767;
            this.txtBusqueda.Multiline = false;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBusqueda.PasswordChar = false;
            this.txtBusqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBusqueda.PlaceholderText = "";
            this.txtBusqueda.Size = new System.Drawing.Size(231, 31);
            this.txtBusqueda.TabIndex = 17;
            this.txtBusqueda.Texts = "";
            this.txtBusqueda.UnderlinedStyle = false;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Paginas";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(438, 544);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(52, 23);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(496, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "de";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(528, 544);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 23);
            this.textBox1.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.06922F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.97997F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.13297F));
            this.tableLayoutPanel1.Controls.Add(this.rjComboBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbFiltros, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(384, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(549, 38);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rjComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.rjComboBox1.BorderSize = 2;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rjComboBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.rjComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.IconColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.Items.AddRange(new object[] {
            "NoFactura",
            "ID Cliente",
            "Sucursal",
            "Fecha"});
            this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rjComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.Location = new System.Drawing.Point(211, 3);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBox1.SelectedValue = null;
            this.rjComboBox1.Size = new System.Drawing.Size(200, 32);
            this.rjComboBox1.TabIndex = 38;
            this.rjComboBox1.Texts = "";
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFiltros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbFiltros.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbFiltros.BorderSize = 2;
            this.cmbFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltros.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmbFiltros.ForeColor = System.Drawing.Color.DimGray;
            this.cmbFiltros.IconColor = System.Drawing.Color.DimGray;
            this.cmbFiltros.Items.AddRange(new object[] {
            "NoFactura",
            "ID Cliente",
            "Sucursal",
            "Fecha"});
            this.cmbFiltros.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbFiltros.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbFiltros.Location = new System.Drawing.Point(3, 3);
            this.cmbFiltros.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.Padding = new System.Windows.Forms.Padding(2);
            this.cmbFiltros.SelectedValue = null;
            this.cmbFiltros.Size = new System.Drawing.Size(200, 32);
            this.cmbFiltros.TabIndex = 37;
            this.cmbFiltros.Texts = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.cmbUnidades, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbCambios, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbEstado, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(348, 40);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(607, 38);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // cmbUnidades
            // 
            this.cmbUnidades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUnidades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUnidades.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbUnidades.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbUnidades.BorderSize = 2;
            this.cmbUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidades.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmbUnidades.ForeColor = System.Drawing.Color.DimGray;
            this.cmbUnidades.IconColor = System.Drawing.Color.DimGray;
            this.cmbUnidades.Items.AddRange(new object[] {
            "ID",
            "ID Usuario",
            "Fecha"});
            this.cmbUnidades.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbUnidades.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbUnidades.Location = new System.Drawing.Point(407, 3);
            this.cmbUnidades.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbUnidades.Name = "cmbUnidades";
            this.cmbUnidades.Padding = new System.Windows.Forms.Padding(2);
            this.cmbUnidades.SelectedValue = null;
            this.cmbUnidades.Size = new System.Drawing.Size(200, 32);
            this.cmbUnidades.TabIndex = 34;
            this.cmbUnidades.Texts = "";
            this.cmbUnidades.Visible = false;
            // 
            // cmbCambios
            // 
            this.cmbCambios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCambios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCambios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCambios.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbCambios.BorderSize = 2;
            this.cmbCambios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCambios.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmbCambios.ForeColor = System.Drawing.Color.DimGray;
            this.cmbCambios.IconColor = System.Drawing.Color.DimGray;
            this.cmbCambios.Items.AddRange(new object[] {
            "Salida de sucursal",
            "Llegada a sucursal"});
            this.cmbCambios.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbCambios.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbCambios.Location = new System.Drawing.Point(205, 3);
            this.cmbCambios.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbCambios.Name = "cmbCambios";
            this.cmbCambios.Padding = new System.Windows.Forms.Padding(2);
            this.cmbCambios.SelectedValue = null;
            this.cmbCambios.Size = new System.Drawing.Size(200, 32);
            this.cmbCambios.TabIndex = 34;
            this.cmbCambios.Texts = "";
            this.cmbCambios.OnSelectedValueChanged += new System.EventHandler(this.cmbCambios_OnSelectedValueChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbEstado.BorderSize = 2;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmbEstado.ForeColor = System.Drawing.Color.DimGray;
            this.cmbEstado.IconColor = System.Drawing.Color.DimGray;
            this.cmbEstado.Items.AddRange(new object[] {
            "En tránsito a sucursal",
            "Recibido en Sucursal",
            "En proceso de entrega",
            "Paquete entregado"});
            this.cmbEstado.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbEstado.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbEstado.Location = new System.Drawing.Point(3, 3);
            this.cmbEstado.MinimumSize = new System.Drawing.Size(190, 30);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Padding = new System.Windows.Forms.Padding(2);
            this.cmbEstado.SelectedValue = null;
            this.cmbEstado.Size = new System.Drawing.Size(196, 32);
            this.cmbEstado.TabIndex = 33;
            this.cmbEstado.Texts = "";
            // 
            // frmEnviosEnCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 588);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEnviosEnCurso";
            this.Text = "Envios en Curso";
            this.Load += new System.EventHandler(this.frmEnviosEnCurso_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private FontAwesome.Sharp.IconButton btnActualizar;
		private FontAwesome.Sharp.IconButton iconButton1;
		private CustomControls.RJControls.RJTextBox txtBusqueda;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomControls.RJComboBox cmbFiltros;
        private CustomControls.RJComboBox rjComboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomControls.RJComboBox cmbUnidades;
        private CustomControls.RJComboBox cmbCambios;
        private CustomControls.RJComboBox cmbEstado;
    }
}