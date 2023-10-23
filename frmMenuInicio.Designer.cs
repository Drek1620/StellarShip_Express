namespace StellarShip_Express
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
            this.panTitle = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.pcbIconTitle = new FontAwesome.Sharp.IconPictureBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pcbImgUsuario = new CustomControls.CircularPictureBox();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnMinum = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panAlmacen = new System.Windows.Forms.Panel();
            this.btnDelivered = new FontAwesome.Sharp.IconButton();
            this.btnSent = new FontAwesome.Sharp.IconButton();
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnDestinos = new FontAwesome.Sharp.IconButton();
            this.btnVehicles = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.btnStaff = new FontAwesome.Sharp.IconButton();
            this.btnParcel = new FontAwesome.Sharp.IconButton();
            this.btnRegister = new FontAwesome.Sharp.IconButton();
            this.panInicio = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImgUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panAlmacen.SuspendLayout();
            this.panMenu.SuspendLayout();
            this.panInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panTitle
            // 
            this.panTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.panTitle.Controls.Add(this.lblTitleChildForm);
            this.panTitle.Controls.Add(this.pcbIconTitle);
            this.panTitle.Controls.Add(this.iconButton2);
            this.panTitle.Controls.Add(this.lblNombre);
            this.panTitle.Controls.Add(this.pcbImgUsuario);
            this.panTitle.Controls.Add(this.btnMaximizar);
            this.panTitle.Controls.Add(this.btnMinum);
            this.panTitle.Controls.Add(this.btnHome);
            this.panTitle.Controls.Add(this.btnClose);
            this.panTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panTitle.ForeColor = System.Drawing.Color.White;
            this.panTitle.Location = new System.Drawing.Point(0, 0);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(1183, 73);
            this.panTitle.TabIndex = 0;
            this.panTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panTitle_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(655, 37);
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
            this.pcbIconTitle.Location = new System.Drawing.Point(619, 31);
            this.pcbIconTitle.Name = "pcbIconTitle";
            this.pcbIconTitle.Size = new System.Drawing.Size(32, 32);
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
            this.iconButton2.Location = new System.Drawing.Point(1150, 32);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(10, 3, 20, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(33, 42);
            this.iconButton2.TabIndex = 10;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(990, 41);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 17);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Default";
            // 
            // pcbImgUsuario
            // 
            this.pcbImgUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pcbImgUsuario.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pcbImgUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.pcbImgUsuario.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.pcbImgUsuario.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pcbImgUsuario.BorderSize = 2;
            this.pcbImgUsuario.GradientAngle = 50F;
            this.pcbImgUsuario.Image = global::StellarShip_Express.Properties.Resources.Null;
            this.pcbImgUsuario.Location = new System.Drawing.Point(944, 27);
            this.pcbImgUsuario.Name = "pcbImgUsuario";
            this.pcbImgUsuario.Size = new System.Drawing.Size(43, 43);
            this.pcbImgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImgUsuario.TabIndex = 8;
            this.pcbImgUsuario.TabStop = false;
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
            this.btnMaximizar.Location = new System.Drawing.Point(1105, 1);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(36, 25);
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
            this.btnMinum.Location = new System.Drawing.Point(1071, 1);
            this.btnMinum.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinum.Name = "btnMinum";
            this.btnMinum.Size = new System.Drawing.Size(36, 25);
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
            this.btnHome.Size = new System.Drawing.Size(220, 73);
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
            this.btnClose.Location = new System.Drawing.Point(1143, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 25);
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
            this.panAlmacen.Location = new System.Drawing.Point(0, 120);
            this.panAlmacen.Name = "panAlmacen";
            this.panAlmacen.Size = new System.Drawing.Size(220, 120);
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
            this.btnDelivered.Location = new System.Drawing.Point(0, 55);
            this.btnDelivered.Name = "btnDelivered";
            this.btnDelivered.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDelivered.Size = new System.Drawing.Size(220, 55);
            this.btnDelivered.TabIndex = 3;
            this.btnDelivered.Text = "Entregados";
            this.btnDelivered.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelivered.UseVisualStyleBackColor = true;
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
            this.btnSent.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSent.Size = new System.Drawing.Size(220, 55);
            this.btnSent.TabIndex = 2;
            this.btnSent.Text = "En Envio";
            this.btnSent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSent.UseVisualStyleBackColor = true;
            // 
            // panMenu
            // 
            this.panMenu.AutoScroll = true;
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.panMenu.Controls.Add(this.btnDestinos);
            this.panMenu.Controls.Add(this.btnVehicles);
            this.panMenu.Controls.Add(this.iconButton8);
            this.panMenu.Controls.Add(this.btnStaff);
            this.panMenu.Controls.Add(this.panAlmacen);
            this.panMenu.Controls.Add(this.btnParcel);
            this.panMenu.Controls.Add(this.btnRegister);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMenu.Location = new System.Drawing.Point(0, 73);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(220, 580);
            this.panMenu.TabIndex = 1;
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
            this.btnDestinos.Location = new System.Drawing.Point(0, 360);
            this.btnDestinos.Name = "btnDestinos";
            this.btnDestinos.Size = new System.Drawing.Size(220, 60);
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
            this.btnVehicles.Location = new System.Drawing.Point(0, 300);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(220, 60);
            this.btnVehicles.TabIndex = 8;
            this.btnVehicles.Text = "Vehiculos";
            this.btnVehicles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVehicles.UseVisualStyleBackColor = true;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // iconButton8
            // 
            this.iconButton8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton8.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.iconButton8.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 35;
            this.iconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.Location = new System.Drawing.Point(0, 520);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(220, 60);
            this.iconButton8.TabIndex = 8;
            this.iconButton8.Text = "Cerrar Sesion";
            this.iconButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton8.UseVisualStyleBackColor = true;
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
            this.btnStaff.Location = new System.Drawing.Point(0, 240);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(220, 60);
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
            this.btnParcel.Location = new System.Drawing.Point(0, 60);
            this.btnParcel.Name = "btnParcel";
            this.btnParcel.Size = new System.Drawing.Size(220, 60);
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
            this.btnRegister.Size = new System.Drawing.Size(220, 60);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // panInicio
            // 
            this.panInicio.Controls.Add(this.pictureBox2);
            this.panInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panInicio.Location = new System.Drawing.Point(220, 73);
            this.panInicio.Name = "panInicio";
            this.panInicio.Size = new System.Drawing.Size(963, 580);
            this.panInicio.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::StellarShip_Express.Properties.Resources.StellarShip_Logo_Tono2;
            this.pictureBox2.Location = new System.Drawing.Point(266, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(466, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 653);
            this.Controls.Add(this.panInicio);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.panTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Menu";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImgUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panAlmacen.ResumeLayout(false);
            this.panMenu.ResumeLayout(false);
            this.panInicio.ResumeLayout(false);
            this.panInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTitle;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnMinum;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnRegister;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton btnStaff;
        private System.Windows.Forms.Panel panAlmacen;
        private FontAwesome.Sharp.IconButton btnDelivered;
        private FontAwesome.Sharp.IconButton btnSent;
        private FontAwesome.Sharp.IconButton btnParcel;
        private CustomControls.CircularPictureBox pcbImgUsuario;
        private System.Windows.Forms.Panel panMenu;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label lblNombre;
        private FontAwesome.Sharp.IconButton btnDestinos;
        private FontAwesome.Sharp.IconButton btnVehicles;
        public System.Windows.Forms.Panel panInicio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox pcbIconTitle;
    }
}

