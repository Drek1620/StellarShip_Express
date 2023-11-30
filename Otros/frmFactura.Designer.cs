namespace StellarShip_Express.Otros
{
	partial class frmFactura
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
			this.dgvDatos = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cmbFiltros = new CustomControls.RJComboBox();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.btnActualizar = new FontAwesome.Sharp.IconButton();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// rjTextBox1
			// 
			this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
			this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
			this.rjTextBox1.BorderRadius = 0;
			this.rjTextBox1.BorderSize = 2;
			this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.rjTextBox1.Location = new System.Drawing.Point(41, 50);
			this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
			this.rjTextBox1.MaxLength = 32767;
			this.rjTextBox1.Multiline = false;
			this.rjTextBox1.Name = "rjTextBox1";
			this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.rjTextBox1.PasswordChar = false;
			this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.rjTextBox1.PlaceholderText = "";
			this.rjTextBox1.Size = new System.Drawing.Size(246, 31);
			this.rjTextBox1.TabIndex = 33;
			this.rjTextBox1.Texts = "";
			this.rjTextBox1.UnderlinedStyle = false;
			// 
			// dgvDatos
			// 
			this.dgvDatos.AllowUserToResizeColumns = false;
			this.dgvDatos.AllowUserToResizeRows = false;
			this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(128)))), ((int)(((byte)(198)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(128)))), ((int)(((byte)(198)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDatos.ColumnHeadersHeight = 30;
			this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvDatos.EnableHeadersVisualStyles = false;
			this.dgvDatos.Location = new System.Drawing.Point(41, 89);
			this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
			this.dgvDatos.MultiSelect = false;
			this.dgvDatos.Name = "dgvDatos";
			this.dgvDatos.ReadOnly = true;
			this.dgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvDatos.Size = new System.Drawing.Size(889, 445);
			this.dgvDatos.TabIndex = 32;
			this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.Controls.Add(this.cmbFiltros, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.dateTimePicker2, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(381, 47);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(549, 37);
			this.tableLayoutPanel1.TabIndex = 36;
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
			this.cmbFiltros.Size = new System.Drawing.Size(200, 30);
			this.cmbFiltros.TabIndex = 37;
			this.cmbFiltros.Texts = "";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(386, 3);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(160, 24);
			this.dateTimePicker2.TabIndex = 25;
			this.dateTimePicker2.Value = new System.DateTime(2023, 11, 29, 0, 0, 0, 0);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(229, 3);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(151, 24);
			this.dateTimePicker1.TabIndex = 24;
			this.dateTimePicker1.Value = new System.DateTime(2023, 11, 24, 0, 0, 0, 0);
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnActualizar.FlatAppearance.BorderSize = 0;
			this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
			this.btnActualizar.IconColor = System.Drawing.Color.White;
			this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnActualizar.IconSize = 25;
			this.btnActualizar.Location = new System.Drawing.Point(331, 50);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(44, 31);
			this.btnActualizar.TabIndex = 35;
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// iconButton1
			// 
			this.iconButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.iconButton1.Cursor = System.Windows.Forms.Cursors.Default;
			this.iconButton1.FlatAppearance.BorderSize = 0;
			this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
			this.iconButton1.IconColor = System.Drawing.Color.White;
			this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton1.IconSize = 25;
			this.iconButton1.Location = new System.Drawing.Point(287, 50);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.Size = new System.Drawing.Size(44, 31);
			this.iconButton1.TabIndex = 34;
			this.iconButton1.UseVisualStyleBackColor = false;
			this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
			// 
			// frmFactura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(970, 580);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.iconButton1);
			this.Controls.Add(this.rjTextBox1);
			this.Controls.Add(this.dgvDatos);
			this.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmFactura";
			this.Text = "Factura";
			this.Load += new System.EventHandler(this.frmFactura_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private FontAwesome.Sharp.IconButton btnActualizar;
		private FontAwesome.Sharp.IconButton iconButton1;
		private CustomControls.RJControls.RJTextBox rjTextBox1;
		private System.Windows.Forms.DataGridView dgvDatos;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private CustomControls.RJComboBox cmbFiltros;
	}
}