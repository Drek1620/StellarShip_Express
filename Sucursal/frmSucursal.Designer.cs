namespace StellarShip_Express.Destino
{
    partial class frmSucursal
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
			this.txtBusqueda = new CustomControls.RJControls.RJTextBox();
			this.dgvDatos = new System.Windows.Forms.DataGridView();
			this.btnActualizar = new FontAwesome.Sharp.IconButton();
			this.btnAgregar = new FontAwesome.Sharp.IconButton();
			this.btnEliminar = new FontAwesome.Sharp.IconButton();
			this.iconButton2 = new FontAwesome.Sharp.IconButton();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.cmbFiltros = new CustomControls.RJComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
			this.SuspendLayout();
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
			this.txtBusqueda.Location = new System.Drawing.Point(52, 49);
			this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4);
			this.txtBusqueda.MaxLength = 32767;
			this.txtBusqueda.Multiline = false;
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.txtBusqueda.PasswordChar = false;
			this.txtBusqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtBusqueda.PlaceholderText = "";
			this.txtBusqueda.Size = new System.Drawing.Size(297, 31);
			this.txtBusqueda.TabIndex = 10;
			this.txtBusqueda.Texts = "";
			this.txtBusqueda.UnderlinedStyle = false;
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
			this.dgvDatos.Location = new System.Drawing.Point(52, 92);
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
			this.dgvDatos.RowHeadersWidth = 62;
			this.dgvDatos.Size = new System.Drawing.Size(866, 445);
			this.dgvDatos.TabIndex = 9;
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
			this.btnActualizar.Location = new System.Drawing.Point(393, 49);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(44, 31);
			this.btnActualizar.TabIndex = 15;
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(139)))), ((int)(((byte)(99)))));
			this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnAgregar.FlatAppearance.BorderSize = 0;
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
			this.btnAgregar.IconColor = System.Drawing.Color.White;
			this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnAgregar.IconSize = 25;
			this.btnAgregar.Location = new System.Drawing.Point(774, 49);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(44, 31);
			this.btnAgregar.TabIndex = 14;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(69)))), ((int)(((byte)(72)))));
			this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
			this.btnEliminar.IconColor = System.Drawing.Color.White;
			this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnEliminar.IconSize = 25;
			this.btnEliminar.Location = new System.Drawing.Point(874, 49);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(44, 31);
			this.btnEliminar.TabIndex = 13;
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// iconButton2
			// 
			this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.iconButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.iconButton2.Cursor = System.Windows.Forms.Cursors.Default;
			this.iconButton2.FlatAppearance.BorderSize = 0;
			this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
			this.iconButton2.IconColor = System.Drawing.Color.White;
			this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton2.IconSize = 25;
			this.iconButton2.Location = new System.Drawing.Point(824, 49);
			this.iconButton2.Name = "iconButton2";
			this.iconButton2.Size = new System.Drawing.Size(44, 31);
			this.iconButton2.TabIndex = 12;
			this.iconButton2.UseVisualStyleBackColor = false;
			this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
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
			this.iconButton1.Location = new System.Drawing.Point(349, 49);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.Size = new System.Drawing.Size(44, 31);
			this.iconButton1.TabIndex = 11;
			this.iconButton1.UseVisualStyleBackColor = false;
			this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            "IdDestino",
            "Nombre",
            "Municipio"});
			this.cmbFiltros.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.cmbFiltros.ListTextColor = System.Drawing.Color.DimGray;
			this.cmbFiltros.Location = new System.Drawing.Point(464, 50);
			this.cmbFiltros.MinimumSize = new System.Drawing.Size(200, 30);
			this.cmbFiltros.Name = "cmbFiltros";
			this.cmbFiltros.Padding = new System.Windows.Forms.Padding(2);
			this.cmbFiltros.SelectedValue = null;
			this.cmbFiltros.Size = new System.Drawing.Size(200, 30);
			this.cmbFiltros.TabIndex = 34;
			this.cmbFiltros.Texts = "";
			// 
			// frmSucursal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(970, 580);
			this.Controls.Add(this.cmbFiltros);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.iconButton2);
			this.Controls.Add(this.iconButton1);
			this.Controls.Add(this.txtBusqueda);
			this.Controls.Add(this.dgvDatos);
			this.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmSucursal";
			this.Text = "Sucursal";
			this.Load += new System.EventHandler(this.frmSucursal_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private CustomControls.RJControls.RJTextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dgvDatos;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private CustomControls.RJComboBox cmbFiltros;
    }
}