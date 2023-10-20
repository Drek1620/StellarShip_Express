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
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.circularPictureBox1 = new CustomControls.CircularPictureBox();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnMinum = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panAlmacen = new System.Windows.Forms.Panel();
            this.btnDelivered = new FontAwesome.Sharp.IconButton();
            this.btnSent = new FontAwesome.Sharp.IconButton();
            this.panMenu = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.btnVehicles = new FontAwesome.Sharp.IconButton();
            this.panPersonal = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnTrabajador = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.btnStaff = new FontAwesome.Sharp.IconButton();
            this.btnParcel = new FontAwesome.Sharp.IconButton();
            this.btnRegister = new FontAwesome.Sharp.IconButton();
            this.panInicio = new System.Windows.Forms.Panel();
            this.panTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panAlmacen.SuspendLayout();
            this.panMenu.SuspendLayout();
            this.panPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTitle
            // 
            this.panTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.panTitle.Controls.Add(this.iconButton2);
            this.panTitle.Controls.Add(this.lblNombre);
            this.panTitle.Controls.Add(this.circularPictureBox1);
            this.panTitle.Controls.Add(this.btnMaximizar);
            this.panTitle.Controls.Add(this.btnMinum);
            this.panTitle.Controls.Add(this.pictureBox1);
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
            // iconButton2
            // 
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
            this.lblNombre.Location = new System.Drawing.Point(992, 42);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 17);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Default";
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.circularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.circularPictureBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.circularPictureBox1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.circularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.circularPictureBox1.BorderSize = 2;
            this.circularPictureBox1.GradientAngle = 50F;
            this.circularPictureBox1.Image = global::StellarShip_Express.Properties.Resources.Null;
            this.circularPictureBox1.Location = new System.Drawing.Point(945, 26);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(44, 44);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 8;
            this.circularPictureBox1.TabStop = false;
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
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::StellarShip_Express.Properties.Resources.StellarShip_Express_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.panAlmacen.Size = new System.Drawing.Size(203, 120);
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
            this.btnDelivered.Size = new System.Drawing.Size(203, 55);
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
            this.btnSent.Size = new System.Drawing.Size(203, 55);
            this.btnSent.TabIndex = 2;
            this.btnSent.Text = "En Envio";
            this.btnSent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSent.UseVisualStyleBackColor = true;
            // 
            // panMenu
            // 
            this.panMenu.AutoScroll = true;
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.panMenu.Controls.Add(this.iconButton5);
            this.panMenu.Controls.Add(this.btnVehicles);
            this.panMenu.Controls.Add(this.panPersonal);
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
            // iconButton5
            // 
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.LocationDot;
            this.iconButton5.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 30;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 480);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(203, 60);
            this.iconButton5.TabIndex = 9;
            this.iconButton5.Text = "Destinos";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
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
            this.btnVehicles.Location = new System.Drawing.Point(0, 420);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(203, 60);
            this.btnVehicles.TabIndex = 8;
            this.btnVehicles.Text = "Vehiculos";
            this.btnVehicles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVehicles.UseVisualStyleBackColor = true;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // panPersonal
            // 
            this.panPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(82)))), ((int)(((byte)(92)))));
            this.panPersonal.Controls.Add(this.iconButton3);
            this.panPersonal.Controls.Add(this.btnTrabajador);
            this.panPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panPersonal.Location = new System.Drawing.Point(0, 300);
            this.panPersonal.Name = "panPersonal";
            this.panPersonal.Size = new System.Drawing.Size(203, 120);
            this.panPersonal.TabIndex = 5;
            this.panPersonal.Visible = false;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.PeopleCarryBox;
            this.iconButton3.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 55);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(203, 55);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.Text = "Transportistas";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // btnTrabajador
            // 
            this.btnTrabajador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrabajador.FlatAppearance.BorderSize = 0;
            this.btnTrabajador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrabajador.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrabajador.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTrabajador.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnTrabajador.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTrabajador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrabajador.IconSize = 30;
            this.btnTrabajador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrabajador.Location = new System.Drawing.Point(0, 0);
            this.btnTrabajador.Name = "btnTrabajador";
            this.btnTrabajador.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTrabajador.Size = new System.Drawing.Size(203, 55);
            this.btnTrabajador.TabIndex = 2;
            this.btnTrabajador.Text = "Sucursal";
            this.btnTrabajador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrabajador.UseVisualStyleBackColor = true;
            this.btnTrabajador.Click += new System.EventHandler(this.btnTrabajador_Click);
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
            this.iconButton8.Location = new System.Drawing.Point(0, 540);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(203, 60);
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
            this.btnStaff.Size = new System.Drawing.Size(203, 60);
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
            this.btnParcel.Size = new System.Drawing.Size(203, 60);
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
            this.btnRegister.Size = new System.Drawing.Size(203, 60);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // panInicio
            // 
            this.panInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panInicio.Location = new System.Drawing.Point(220, 73);
            this.panInicio.Name = "panInicio";
            this.panInicio.Size = new System.Drawing.Size(963, 580);
            this.panInicio.TabIndex = 2;
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
            this.Text = "frm_Menu";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panAlmacen.ResumeLayout(false);
            this.panMenu.ResumeLayout(false);
            this.panPersonal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private CustomControls.CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Panel panMenu;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label lblNombre;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton btnVehicles;
        private System.Windows.Forms.Panel panPersonal;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnTrabajador;
        public System.Windows.Forms.Panel panInicio;
    }
}

