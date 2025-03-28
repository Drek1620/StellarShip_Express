﻿namespace StellarShip_Express
{
    partial class frm_Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.panTitle = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pcbImgUsuario = new CustomControls.CircularPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.pcbIconTitle = new FontAwesome.Sharp.IconPictureBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnMinum = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panAlmacen = new System.Windows.Forms.Panel();
            this.btnDelivered = new FontAwesome.Sharp.IconButton();
            this.btnSent = new FontAwesome.Sharp.IconButton();
            this.panMenu = new System.Windows.Forms.Panel();
            this.panRegis = new System.Windows.Forms.Panel();
            this.btnBitacora = new FontAwesome.Sharp.IconButton();
            this.btnFactura = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.btnRegistros = new FontAwesome.Sharp.IconButton();
            this.btnDestinos = new FontAwesome.Sharp.IconButton();
            this.btnVehicles = new FontAwesome.Sharp.IconButton();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.btnStaff = new FontAwesome.Sharp.IconButton();
            this.btnParcel = new FontAwesome.Sharp.IconButton();
            this.btnRegister = new FontAwesome.Sharp.IconButton();
            this.panInicio = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rjDropdownMenu1 = new StellarShip_Express.DropDown.RJDropdownMenu(this.components);
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panTitle.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImgUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panAlmacen.SuspendLayout();
            this.panMenu.SuspendLayout();
            this.panRegis.SuspendLayout();
            this.panInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.rjDropdownMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTitle
            // 
            this.panTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.panTitle.Controls.Add(this.tableLayoutPanel1);
            this.panTitle.Controls.Add(this.lblTitleChildForm);
            this.panTitle.Controls.Add(this.pcbIconTitle);
            this.panTitle.Controls.Add(this.iconButton2);
            this.panTitle.Controls.Add(this.btnMaximizar);
            this.panTitle.Controls.Add(this.btnMinum);
            this.panTitle.Controls.Add(this.btnHome);
            this.panTitle.Controls.Add(this.btnClose);
            this.panTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panTitle.ForeColor = System.Drawing.Color.White;
            this.panTitle.Location = new System.Drawing.Point(0, 0);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(1245, 76);
            this.panTitle.TabIndex = 0;
            this.panTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panTitle_MouseDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblNombre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pcbImgUsuario, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1094, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(110, 52);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(52, 0);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNombre.Size = new System.Drawing.Size(58, 52);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Default";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbImgUsuario
            // 
            this.pcbImgUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbImgUsuario.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pcbImgUsuario.BorderColor = System.Drawing.Color.White;
            this.pcbImgUsuario.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pcbImgUsuario.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pcbImgUsuario.BorderSize = 2;
            this.pcbImgUsuario.GradientAngle = 50F;
            this.pcbImgUsuario.Image = global::StellarShip_Express.Properties.Resources.Null;
            this.pcbImgUsuario.Location = new System.Drawing.Point(3, 3);
            this.pcbImgUsuario.MinimumSize = new System.Drawing.Size(46, 46);
            this.pcbImgUsuario.Name = "pcbImgUsuario";
            this.pcbImgUsuario.Size = new System.Drawing.Size(46, 46);
            this.pcbImgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImgUsuario.TabIndex = 8;
            this.pcbImgUsuario.TabStop = false;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(690, 37);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(51, 19);
            this.lblTitleChildForm.TabIndex = 12;
            this.lblTitleChildForm.Text = "Inicio";
            // 
            // pcbIconTitle
            // 
            this.pcbIconTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pcbIconTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.pcbIconTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pcbIconTitle.IconChar = FontAwesome.Sharp.IconChar.House;
            this.pcbIconTitle.IconColor = System.Drawing.Color.WhiteSmoke;
            this.pcbIconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pcbIconTitle.IconSize = 34;
            this.pcbIconTitle.Location = new System.Drawing.Point(652, 30);
            this.pcbIconTitle.Name = "pcbIconTitle";
            this.pcbIconTitle.Size = new System.Drawing.Size(34, 35);
            this.pcbIconTitle.TabIndex = 11;
            this.pcbIconTitle.TabStop = false;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.EllipsisVertical;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.Location = new System.Drawing.Point(1210, 31);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(10, 3, 22, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(35, 42);
            this.iconButton2.TabIndex = 10;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnMaximizar.IconColor = System.Drawing.Color.White;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 20;
            this.btnMaximizar.Location = new System.Drawing.Point(1162, 2);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(38, 25);
            this.btnMaximizar.TabIndex = 7;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
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
            this.btnMinum.Location = new System.Drawing.Point(1126, 2);
            this.btnMinum.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinum.Name = "btnMinum";
            this.btnMinum.Size = new System.Drawing.Size(38, 25);
            this.btnMinum.TabIndex = 6;
            this.btnMinum.UseVisualStyleBackColor = true;
            this.btnMinum.Click += new System.EventHandler(this.btnMinum_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.Image = global::StellarShip_Express.Properties.Resources.StellarShip_Express_logo;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(234, 76);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            this.btnClose.Location = new System.Drawing.Point(1202, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panAlmacen
            // 
            this.panAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(82)))), ((int)(((byte)(92)))));
            this.panAlmacen.Controls.Add(this.btnDelivered);
            this.panAlmacen.Controls.Add(this.btnSent);
            this.panAlmacen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panAlmacen.Location = new System.Drawing.Point(0, 118);
            this.panAlmacen.Name = "panAlmacen";
            this.panAlmacen.Size = new System.Drawing.Size(217, 118);
            this.panAlmacen.TabIndex = 4;
            this.panAlmacen.Visible = false;
            // 
            // btnDelivered
            // 
            this.btnDelivered.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelivered.FlatAppearance.BorderSize = 0;
            this.btnDelivered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivered.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivered.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelivered.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btnDelivered.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDelivered.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelivered.IconSize = 30;
            this.btnDelivered.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelivered.Location = new System.Drawing.Point(0, 54);
            this.btnDelivered.Name = "btnDelivered";
            this.btnDelivered.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnDelivered.Size = new System.Drawing.Size(217, 54);
            this.btnDelivered.TabIndex = 3;
            this.btnDelivered.Text = "Entregados";
            this.btnDelivered.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelivered.UseVisualStyleBackColor = true;
            this.btnDelivered.Click += new System.EventHandler(this.btnDelivered_Click);
            // 
            // btnSent
            // 
            this.btnSent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSent.FlatAppearance.BorderSize = 0;
            this.btnSent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSent.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSent.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            this.btnSent.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSent.IconSize = 30;
            this.btnSent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSent.Location = new System.Drawing.Point(0, 0);
            this.btnSent.Name = "btnSent";
            this.btnSent.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnSent.Size = new System.Drawing.Size(217, 54);
            this.btnSent.TabIndex = 2;
            this.btnSent.Text = "En Envio";
            this.btnSent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSent.UseVisualStyleBackColor = true;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // panMenu
            // 
            this.panMenu.AutoScroll = true;
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.panMenu.Controls.Add(this.panRegis);
            this.panMenu.Controls.Add(this.btnRegistros);
            this.panMenu.Controls.Add(this.btnDestinos);
            this.panMenu.Controls.Add(this.btnVehicles);
            this.panMenu.Controls.Add(this.btnCerrarSesion);
            this.panMenu.Controls.Add(this.btnStaff);
            this.panMenu.Controls.Add(this.panAlmacen);
            this.panMenu.Controls.Add(this.btnParcel);
            this.panMenu.Controls.Add(this.btnRegister);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMenu.Location = new System.Drawing.Point(0, 76);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(234, 567);
            this.panMenu.TabIndex = 1;
            // 
            // panRegis
            // 
            this.panRegis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(82)))), ((int)(((byte)(92)))));
            this.panRegis.Controls.Add(this.btnBitacora);
            this.panRegis.Controls.Add(this.btnFactura);
            this.panRegis.Controls.Add(this.btnClientes);
            this.panRegis.Dock = System.Windows.Forms.DockStyle.Top;
            this.panRegis.Location = new System.Drawing.Point(0, 472);
            this.panRegis.Name = "panRegis";
            this.panRegis.Size = new System.Drawing.Size(217, 174);
            this.panRegis.TabIndex = 11;
            this.panRegis.Visible = false;
            // 
            // btnBitacora
            // 
            this.btnBitacora.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBitacora.FlatAppearance.BorderSize = 0;
            this.btnBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitacora.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBitacora.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBitacora.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBitacora.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBitacora.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBitacora.IconSize = 30;
            this.btnBitacora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBitacora.Location = new System.Drawing.Point(0, 108);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnBitacora.Size = new System.Drawing.Size(217, 54);
            this.btnBitacora.TabIndex = 4;
            this.btnBitacora.Text = "Bitacora";
            this.btnBitacora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBitacora.UseVisualStyleBackColor = true;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFactura.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFactura.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFactura.IconSize = 30;
            this.btnFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactura.Location = new System.Drawing.Point(0, 54);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnFactura.Size = new System.Drawing.Size(217, 54);
            this.btnFactura.TabIndex = 3;
            this.btnFactura.Text = "Facturas";
            this.btnFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClientes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 30;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(217, 54);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnRegistros
            // 
            this.btnRegistros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistros.FlatAppearance.BorderSize = 0;
            this.btnRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistros.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistros.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegistros.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnRegistros.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRegistros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistros.IconSize = 30;
            this.btnRegistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistros.Location = new System.Drawing.Point(0, 413);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(217, 59);
            this.btnRegistros.TabIndex = 10;
            this.btnRegistros.Text = "Registros";
            this.btnRegistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistros.UseVisualStyleBackColor = true;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // btnDestinos
            // 
            this.btnDestinos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDestinos.FlatAppearance.BorderSize = 0;
            this.btnDestinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestinos.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestinos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDestinos.IconChar = FontAwesome.Sharp.IconChar.LocationDot;
            this.btnDestinos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDestinos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDestinos.IconSize = 30;
            this.btnDestinos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDestinos.Location = new System.Drawing.Point(0, 354);
            this.btnDestinos.Name = "btnDestinos";
            this.btnDestinos.Size = new System.Drawing.Size(217, 59);
            this.btnDestinos.TabIndex = 9;
            this.btnDestinos.Text = "Sucursal";
            this.btnDestinos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDestinos.UseVisualStyleBackColor = true;
            this.btnDestinos.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // btnVehicles
            // 
            this.btnVehicles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehicles.FlatAppearance.BorderSize = 0;
            this.btnVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicles.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicles.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVehicles.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnVehicles.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVehicles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVehicles.IconSize = 30;
            this.btnVehicles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicles.Location = new System.Drawing.Point(0, 295);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(217, 59);
            this.btnVehicles.TabIndex = 8;
            this.btnVehicles.Text = "Vehiculos";
            this.btnVehicles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVehicles.UseVisualStyleBackColor = true;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.IconSize = 35;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 646);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(217, 59);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStaff.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnStaff.IconColor = System.Drawing.Color.Gainsboro;
            this.btnStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStaff.IconSize = 35;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(0, 236);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(217, 59);
            this.btnStaff.TabIndex = 5;
            this.btnStaff.Text = "Personal";
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnParcel
            // 
            this.btnParcel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParcel.FlatAppearance.BorderSize = 0;
            this.btnParcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParcel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParcel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnParcel.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.btnParcel.IconColor = System.Drawing.Color.Gainsboro;
            this.btnParcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnParcel.IconSize = 35;
            this.btnParcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParcel.Location = new System.Drawing.Point(0, 59);
            this.btnParcel.Name = "btnParcel";
            this.btnParcel.Size = new System.Drawing.Size(217, 59);
            this.btnParcel.TabIndex = 1;
            this.btnParcel.Text = "Almacen";
            this.btnParcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParcel.UseVisualStyleBackColor = true;
            this.btnParcel.Click += new System.EventHandler(this.btnParcel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegister.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            this.btnRegister.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegister.IconSize = 35;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(0, 0);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(217, 59);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // panInicio
            // 
            this.panInicio.AutoScroll = true;
            this.panInicio.Controls.Add(this.pictureBox2);
            this.panInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panInicio.Location = new System.Drawing.Point(234, 76);
            this.panInicio.Name = "panInicio";
            this.panInicio.Size = new System.Drawing.Size(1011, 567);
            this.panInicio.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::StellarShip_Express.Properties.Resources.StellarShip;
            this.pictureBox2.Location = new System.Drawing.Point(251, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(544, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.IsMainMenu = false;
            this.rjDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(151, 48);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 643);
            this.Controls.Add(this.panInicio);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.panTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1014, 590);
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Menu";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImgUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panAlmacen.ResumeLayout(false);
            this.panMenu.ResumeLayout(false);
            this.panRegis.ResumeLayout(false);
            this.panInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.rjDropdownMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTitle;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnMinum;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnRegister;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private FontAwesome.Sharp.IconButton btnStaff;
        private System.Windows.Forms.Panel panAlmacen;
        private FontAwesome.Sharp.IconButton btnDelivered;
        private FontAwesome.Sharp.IconButton btnSent;
        private FontAwesome.Sharp.IconButton btnParcel;
        private CustomControls.CircularPictureBox pcbImgUsuario;
        private System.Windows.Forms.Panel panMenu;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnDestinos;
        private FontAwesome.Sharp.IconButton btnVehicles;
        public System.Windows.Forms.Panel panInicio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox pcbIconTitle;
		private FontAwesome.Sharp.IconButton btnRegistros;
		private System.Windows.Forms.Panel panRegis;
		private FontAwesome.Sharp.IconButton btnBitacora;
		private FontAwesome.Sharp.IconButton btnFactura;
		private FontAwesome.Sharp.IconButton btnClientes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNombre;
        private DropDown.RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

