namespace StellarShip_Express.Formularios
{
    partial class frmPersonal
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
			this.dgvDatos = new System.Windows.Forms.DataGridView();
			this.txtBuscar = new CustomControls.RJControls.RJTextBox();
			this.btnActualizar = new FontAwesome.Sharp.IconButton();
			this.btnAgregar = new FontAwesome.Sharp.IconButton();
			this.btnEliminar = new FontAwesome.Sharp.IconButton();
			this.btnEditar = new FontAwesome.Sharp.IconButton();
			this.btnBuscar = new FontAwesome.Sharp.IconButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
			this.SuspendLayout();
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
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(128)))), ((int)(((byte)(198)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDatos.ColumnHeadersHeight = 30;
			this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvDatos.EnableHeadersVisualStyles = false;
			this.dgvDatos.Location = new System.Drawing.Point(41, 90);
			this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
			this.dgvDatos.MultiSelect = false;
			this.dgvDatos.Name = "dgvDatos";
			this.dgvDatos.ReadOnly = true;
			this.dgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvDatos.Size = new System.Drawing.Size(889, 445);
			this.dgvDatos.TabIndex = 2;
			this.dgvDatos.Resize += new System.EventHandler(this.dgvDatos_Resize);
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
			this.txtBuscar.Location = new System.Drawing.Point(41, 51);
			this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
			this.txtBuscar.MaxLength = 32767;
			this.txtBuscar.Multiline = false;
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.txtBuscar.PasswordChar = false;
			this.txtBuscar.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtBuscar.PlaceholderText = "";
			this.txtBuscar.Size = new System.Drawing.Size(297, 31);
			this.txtBuscar.TabIndex = 4;
			this.txtBuscar.Texts = "";
			this.txtBuscar.UnderlinedStyle = false;
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
			this.btnActualizar.Location = new System.Drawing.Point(382, 51);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(44, 31);
			this.btnActualizar.TabIndex = 16;
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
			this.btnAgregar.Location = new System.Drawing.Point(786, 51);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(44, 31);
			this.btnAgregar.TabIndex = 8;
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
			this.btnEliminar.Location = new System.Drawing.Point(886, 51);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(44, 31);
			this.btnEliminar.TabIndex = 7;
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditar.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnEditar.FlatAppearance.BorderSize = 0;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
			this.btnEditar.IconColor = System.Drawing.Color.White;
			this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnEditar.IconSize = 25;
			this.btnEditar.Location = new System.Drawing.Point(836, 51);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(44, 31);
			this.btnEditar.TabIndex = 6;
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
			this.btnBuscar.Location = new System.Drawing.Point(338, 51);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(44, 31);
			this.btnBuscar.TabIndex = 5;
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// frmPersonal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(970, 580);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.dgvDatos);
			this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "frmPersonal";
			this.Text = "Personal";
			this.Load += new System.EventHandler(this.frmPersonal_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private CustomControls.RJControls.RJTextBox txtBuscar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnActualizar;
    }
}