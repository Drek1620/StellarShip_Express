namespace StellarShip_Express.Otros
{
	partial class frmClientes
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cmbFiltros = new CustomControls.RJComboBox();
			this.dgvDatos = new System.Windows.Forms.DataGridView();
			this.btnActualizar = new FontAwesome.Sharp.IconButton();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
			this.SuspendLayout();
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
			this.tableLayoutPanel1.Location = new System.Drawing.Point(381, 46);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(549, 36);
			this.tableLayoutPanel1.TabIndex = 31;
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
            "ID",
            "Nombre",
            "Ciudad",
            "Estado",
            "País"});
			this.cmbFiltros.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.cmbFiltros.ListTextColor = System.Drawing.Color.DimGray;
			this.cmbFiltros.Location = new System.Drawing.Point(3, 3);
			this.cmbFiltros.MinimumSize = new System.Drawing.Size(200, 30);
			this.cmbFiltros.Name = "cmbFiltros";
			this.cmbFiltros.Padding = new System.Windows.Forms.Padding(2);
			this.cmbFiltros.SelectedValue = null;
			this.cmbFiltros.Size = new System.Drawing.Size(200, 30);
			this.cmbFiltros.TabIndex = 32;
			this.cmbFiltros.Texts = "";
			this.cmbFiltros.OnSelectedIndexChanged += new System.EventHandler(this.cmbFiltros_OnSelectedIndexChanged);
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
			this.dgvDatos.TabIndex = 27;
			this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
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
			this.btnActualizar.TabIndex = 30;
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
			this.iconButton1.TabIndex = 29;
			this.iconButton1.UseVisualStyleBackColor = false;
			this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(40, 50);
			this.txt1.Multiline = true;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(249, 31);
			this.txt1.TabIndex = 33;
			// 
			// frmClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(970, 580);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.iconButton1);
			this.Controls.Add(this.dgvDatos);
			this.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmClientes";
			this.Text = "Clientes";
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private FontAwesome.Sharp.IconButton btnActualizar;
		private FontAwesome.Sharp.IconButton iconButton1;
		private System.Windows.Forms.DataGridView dgvDatos;
		private CustomControls.RJComboBox cmbFiltros;
        private System.Windows.Forms.TextBox txt1;
    }
}