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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
			this.dgvDatos = new System.Windows.Forms.DataGridView();
			this.btnActualizar = new FontAwesome.Sharp.IconButton();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.rjComboBox1 = new CustomControls.RJComboBox();
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
			this.tableLayoutPanel1.Controls.Add(this.rjComboBox1, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(381, 46);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(549, 36);
			this.tableLayoutPanel1.TabIndex = 31;
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
			this.rjTextBox1.Multiline = false;
			this.rjTextBox1.Name = "rjTextBox1";
			this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.rjTextBox1.PasswordChar = false;
			this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.rjTextBox1.PlaceholderText = "";
			this.rjTextBox1.Size = new System.Drawing.Size(246, 31);
			this.rjTextBox1.TabIndex = 28;
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
			this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(128)))), ((int)(((byte)(198)))));
			dataGridViewCellStyle28.Font = new System.Drawing.Font("Century Gothic", 10F);
			dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(128)))), ((int)(((byte)(198)))));
			dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
			this.dgvDatos.ColumnHeadersHeight = 30;
			this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle29.Font = new System.Drawing.Font("Century Gothic", 10F);
			dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle29;
			this.dgvDatos.EnableHeadersVisualStyles = false;
			this.dgvDatos.Location = new System.Drawing.Point(41, 89);
			this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
			this.dgvDatos.MultiSelect = false;
			this.dgvDatos.Name = "dgvDatos";
			this.dgvDatos.ReadOnly = true;
			this.dgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle30.Font = new System.Drawing.Font("Century Gothic", 10F);
			dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
			this.dgvDatos.Size = new System.Drawing.Size(889, 445);
			this.dgvDatos.TabIndex = 27;
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
            "ID",
            "Nombre",
            "Ciudad",
            "Estado",
            "País"});
			this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.rjComboBox1.ListTextColor = System.Drawing.Color.DimGray;
			this.rjComboBox1.Location = new System.Drawing.Point(3, 3);
			this.rjComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
			this.rjComboBox1.Name = "rjComboBox1";
			this.rjComboBox1.Padding = new System.Windows.Forms.Padding(2);
			this.rjComboBox1.SelectedValue = null;
			this.rjComboBox1.Size = new System.Drawing.Size(200, 30);
			this.rjComboBox1.TabIndex = 32;
			this.rjComboBox1.Texts = "";
			// 
			// frmClientes
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
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmClientes";
			this.Text = "Clientes";
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private FontAwesome.Sharp.IconButton btnActualizar;
		private FontAwesome.Sharp.IconButton iconButton1;
		private CustomControls.RJControls.RJTextBox rjTextBox1;
		private System.Windows.Forms.DataGridView dgvDatos;
		private CustomControls.RJComboBox rjComboBox1;
	}
}