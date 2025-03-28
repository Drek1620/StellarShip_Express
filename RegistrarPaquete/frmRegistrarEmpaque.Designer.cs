﻿namespace StellarShip_Express.RegistrarPaquete
{
    partial class frmRegistrarEmpaque
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbEmbalaje = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpRemitente = new System.Windows.Forms.TableLayoutPanel();
            this.txtAncho = new CustomControls.RJControls.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLargo = new CustomControls.RJControls.RJTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKg = new CustomControls.RJControls.RJTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.chkSeguro = new System.Windows.Forms.CheckBox();
            this.chkPeligroso = new System.Windows.Forms.CheckBox();
            this.chkIrregular = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPaquetes = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnVolver = new CustomControls.RButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new CustomControls.RButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfirmar = new CustomControls.RButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.BtnInfo = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.tlpRemitente.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEmbalaje
            // 
            this.cmbEmbalaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEmbalaje.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbEmbalaje.DropDownHeight = 400;
            this.cmbEmbalaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmbalaje.DropDownWidth = 50;
            this.cmbEmbalaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.cmbEmbalaje.FormattingEnabled = true;
            this.cmbEmbalaje.IntegralHeight = false;
            this.cmbEmbalaje.Location = new System.Drawing.Point(41, 105);
            this.cmbEmbalaje.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEmbalaje.Name = "cmbEmbalaje";
            this.cmbEmbalaje.Size = new System.Drawing.Size(787, 99);
            this.cmbEmbalaje.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(36, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 28);
            this.label10.TabIndex = 12;
            this.label10.Text = "Registrar Paquete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo de embalaje";
            // 
            // tlpRemitente
            // 
            this.tlpRemitente.ColumnCount = 3;
            this.tlpRemitente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRemitente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRemitente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRemitente.Controls.Add(this.txtAncho, 2, 1);
            this.tlpRemitente.Controls.Add(this.label7, 2, 0);
            this.tlpRemitente.Controls.Add(this.label2, 0, 0);
            this.tlpRemitente.Controls.Add(this.txtLargo, 0, 1);
            this.tlpRemitente.Location = new System.Drawing.Point(41, 260);
            this.tlpRemitente.Name = "tlpRemitente";
            this.tlpRemitente.RowCount = 2;
            this.tlpRemitente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRemitente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpRemitente.Size = new System.Drawing.Size(628, 99);
            this.tlpRemitente.TabIndex = 14;
            // 
            // txtAncho
            // 
            this.txtAncho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAncho.BackColor = System.Drawing.SystemColors.Window;
            this.txtAncho.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtAncho.BorderFocusColor = System.Drawing.SystemColors.HotTrack;
            this.txtAncho.BorderRadius = 5;
            this.txtAncho.BorderSize = 2;
            this.txtAncho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAncho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAncho.Location = new System.Drawing.Point(328, 24);
            this.txtAncho.Margin = new System.Windows.Forms.Padding(4);
            this.txtAncho.MaxLength = 32767;
            this.txtAncho.Multiline = false;
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Padding = new System.Windows.Forms.Padding(20, 15, 15, 15);
            this.txtAncho.PasswordChar = false;
            this.txtAncho.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAncho.PlaceholderText = "Ancho";
            this.txtAncho.Size = new System.Drawing.Size(296, 51);
            this.txtAncho.TabIndex = 13;
            this.txtAncho.Texts = "";
            this.txtAncho.UnderlinedStyle = false;
            this.txtAncho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAncho_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(327, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ancho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Largo";
            // 
            // txtLargo
            // 
            this.txtLargo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLargo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtLargo.BackColor = System.Drawing.SystemColors.Window;
            this.txtLargo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLargo.BorderFocusColor = System.Drawing.SystemColors.HotTrack;
            this.txtLargo.BorderRadius = 5;
            this.txtLargo.BorderSize = 2;
            this.txtLargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLargo.Location = new System.Drawing.Point(4, 24);
            this.txtLargo.Margin = new System.Windows.Forms.Padding(4);
            this.txtLargo.MaxLength = 32767;
            this.txtLargo.Multiline = false;
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Padding = new System.Windows.Forms.Padding(20, 15, 15, 15);
            this.txtLargo.PasswordChar = false;
            this.txtLargo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLargo.PlaceholderText = "Largo";
            this.txtLargo.Size = new System.Drawing.Size(296, 51);
            this.txtLargo.TabIndex = 0;
            this.txtLargo.Texts = "";
            this.txtLargo.UnderlinedStyle = false;
            this.txtLargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLargo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(37, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(361, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Dimensiones del paquete (Centimetros)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Peso del paquete";
            // 
            // txtKg
            // 
            this.txtKg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtKg.BackColor = System.Drawing.SystemColors.Window;
            this.txtKg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtKg.BorderFocusColor = System.Drawing.SystemColors.HotTrack;
            this.txtKg.BorderRadius = 5;
            this.txtKg.BorderSize = 2;
            this.txtKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKg.Location = new System.Drawing.Point(4, 24);
            this.txtKg.Margin = new System.Windows.Forms.Padding(4);
            this.txtKg.MaxLength = 32767;
            this.txtKg.Multiline = false;
            this.txtKg.Name = "txtKg";
            this.txtKg.Padding = new System.Windows.Forms.Padding(20, 15, 15, 15);
            this.txtKg.PasswordChar = false;
            this.txtKg.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtKg.PlaceholderText = "Kg";
            this.txtKg.Size = new System.Drawing.Size(296, 51);
            this.txtKg.TabIndex = 17;
            this.txtKg.Texts = "";
            this.txtKg.UnderlinedStyle = false;
            this.txtKg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKg_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtKg, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(41, 390);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(628, 99);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kilogramos";
            // 
            // chkSeguro
            // 
            this.chkSeguro.AutoSize = true;
            this.chkSeguro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSeguro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.chkSeguro.Location = new System.Drawing.Point(44, 519);
            this.chkSeguro.Name = "chkSeguro";
            this.chkSeguro.Size = new System.Drawing.Size(82, 23);
            this.chkSeguro.TabIndex = 19;
            this.chkSeguro.Text = "Seguro";
            this.chkSeguro.UseVisualStyleBackColor = true;
            this.chkSeguro.CheckedChanged += new System.EventHandler(this.chkSeguro_CheckedChanged);
            // 
            // chkPeligroso
            // 
            this.chkPeligroso.AutoSize = true;
            this.chkPeligroso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPeligroso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.chkPeligroso.Location = new System.Drawing.Point(44, 548);
            this.chkPeligroso.Name = "chkPeligroso";
            this.chkPeligroso.Size = new System.Drawing.Size(188, 23);
            this.chkPeligroso.TabIndex = 20;
            this.chkPeligroso.Text = "Materiales peligrosos";
            this.chkPeligroso.UseVisualStyleBackColor = true;
            this.chkPeligroso.CheckedChanged += new System.EventHandler(this.chkPeligroso_CheckedChanged);
            // 
            // chkIrregular
            // 
            this.chkIrregular.AutoSize = true;
            this.chkIrregular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkIrregular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.chkIrregular.Location = new System.Drawing.Point(44, 584);
            this.chkIrregular.Name = "chkIrregular";
            this.chkIrregular.Size = new System.Drawing.Size(162, 23);
            this.chkIrregular.TabIndex = 21;
            this.chkIrregular.Text = "Paquete irregular";
            this.chkIrregular.UseVisualStyleBackColor = true;
            this.chkIrregular.CheckedChanged += new System.EventHandler(this.chkIrregular_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(37, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Servicios extras";
            // 
            // dgvPaquetes
            // 
            this.dgvPaquetes.AllowUserToResizeColumns = false;
            this.dgvPaquetes.AllowUserToResizeRows = false;
            this.dgvPaquetes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPaquetes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaquetes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPaquetes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(128)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(128)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaquetes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPaquetes.ColumnHeadersHeight = 30;
            this.dgvPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaquetes.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPaquetes.EnableHeadersVisualStyles = false;
            this.dgvPaquetes.Location = new System.Drawing.Point(41, 719);
            this.dgvPaquetes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPaquetes.MultiSelect = false;
            this.dgvPaquetes.Name = "dgvPaquetes";
            this.dgvPaquetes.ReadOnly = true;
            this.dgvPaquetes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaquetes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPaquetes.Size = new System.Drawing.Size(787, 135);
            this.dgvPaquetes.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(40, 678);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(239, 22);
            this.label11.TabIndex = 26;
            this.label11.Text = "Detalles del envio (Max 3)";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(69)))), ((int)(((byte)(72)))));
            this.btnVolver.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(69)))), ((int)(((byte)(72)))));
            this.btnVolver.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVolver.BorderRadius = 5;
            this.btnVolver.BorderSize = 0;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(41, 11);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(183, 40);
            this.btnVolver.TabIndex = 28;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextColor = System.Drawing.Color.White;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Location = new System.Drawing.Point(0, 856);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 87);
            this.panel1.TabIndex = 29;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAgregar.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 5;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(315, 618);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(183, 40);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Location = new System.Drawing.Point(484, 856);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 87);
            this.panel2.TabIndex = 31;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(139)))), ((int)(((byte)(99)))));
            this.btnConfirmar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(139)))), ((int)(((byte)(99)))));
            this.btnConfirmar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirmar.BorderRadius = 5;
            this.btnConfirmar.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(148, 11);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(183, 40);
            this.btnConfirmar.TabIndex = 28;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextColor = System.Drawing.Color.White;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(784, 681);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(44, 31);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnInfo
            // 
            this.BtnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInfo.BackColor = System.Drawing.Color.Transparent;
            this.BtnInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnInfo.FlatAppearance.BorderSize = 0;
            this.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInfo.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.BtnInfo.IconColor = System.Drawing.Color.CornflowerBlue;
            this.BtnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInfo.IconSize = 35;
            this.BtnInfo.Location = new System.Drawing.Point(240, 548);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(27, 27);
            this.BtnInfo.TabIndex = 33;
            this.toolTip1.SetToolTip(this.BtnInfo, "Perfumes, hielo seco, baterías de litio, armas de fuego, encendedores, combustibl" +
        "es, etc.");
            this.BtnInfo.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconButton1.IconColor = System.Drawing.Color.CornflowerBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(240, 580);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(27, 27);
            this.iconButton1.TabIndex = 34;
            this.toolTip1.SetToolTip(this.iconButton1, "Para tipos de paquetes inusuales como cámaras, cajas de madera, neumáticos, etc.");
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // frmRegistrarEmpaque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 788);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.BtnInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvPaquetes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkIrregular);
            this.Controls.Add(this.chkPeligroso);
            this.Controls.Add(this.chkSeguro);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tlpRemitente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmbalaje);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistrarEmpaque";
            this.Text = "frmRegistrarEmpaque";
            this.Load += new System.EventHandler(this.frmRegistrarEmpaque_Load);
            this.tlpRemitente.ResumeLayout(false);
            this.tlpRemitente.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmbalaje;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpRemitente;
        private CustomControls.RJControls.RJTextBox txtAncho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox txtLargo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox txtKg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkSeguro;
        private System.Windows.Forms.CheckBox chkPeligroso;
        private System.Windows.Forms.CheckBox chkIrregular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPaquetes;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private CustomControls.RButton btnVolver;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RButton btnAgregar;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RButton btnConfirmar;
        private FontAwesome.Sharp.IconButton BtnInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}