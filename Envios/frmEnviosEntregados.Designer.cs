namespace StellarShip_Express.Envios
{
	partial class frmEnviosEntregados
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
			this.btnActualizar = new FontAwesome.Sharp.IconButton();
			this.btnBuscar = new FontAwesome.Sharp.IconButton();
			this.txtBuscar = new CustomControls.RJControls.RJTextBox();
			this.dgvDatos = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
			this.SuspendLayout();
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
			this.btnActualizar.Location = new System.Drawing.Point(382, 48);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(44, 31);
			this.btnActualizar.TabIndex = 20;
			this.btnActualizar.UseVisualStyleBackColor = false;
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
			this.btnBuscar.IconColor = System.Drawing.Color.White;
			this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnBuscar.IconSize = 25;
			this.btnBuscar.Location = new System.Drawing.Point(338, 48);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(44, 31);
			this.btnBuscar.TabIndex = 19;
			this.btnBuscar.UseVisualStyleBackColor = false;
			// 
			// txtBuscar
			// 
			this.txtBuscar.BackColor = System.Drawing.SystemColors.Window;
			this.txtBuscar.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.txtBuscar.BorderFocusColor = System.Drawing.Color.HotPink;
			this.txtBuscar.BorderRadius = 0;
			this.txtBuscar.BorderSize = 2;
			this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtBuscar.Location = new System.Drawing.Point(41, 48);
			this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
			this.txtBuscar.MaxLength = 32767;
			this.txtBuscar.Multiline = false;
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.txtBuscar.PasswordChar = false;
			this.txtBuscar.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtBuscar.PlaceholderText = "";
			this.txtBuscar.Size = new System.Drawing.Size(297, 31);
			this.txtBuscar.TabIndex = 18;
			this.txtBuscar.Texts = "";
			this.txtBuscar.UnderlinedStyle = false;
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
			this.dgvDatos.Location = new System.Drawing.Point(41, 87);
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
			this.dgvDatos.TabIndex = 17;
			// 
			// frmEnviosEntregados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(970, 580);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.dgvDatos);
			this.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmEnviosEntregados";
			this.Text = "Envios Entregados";
			this.Load += new System.EventHandler(this.frmEnviosEntregados_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private FontAwesome.Sharp.IconButton btnActualizar;
		private FontAwesome.Sharp.IconButton btnBuscar;
		private CustomControls.RJControls.RJTextBox txtBuscar;
		private System.Windows.Forms.DataGridView dgvDatos;
	}
}