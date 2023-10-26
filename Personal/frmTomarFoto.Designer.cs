namespace StellarShip_Express.Personal
{
    partial class frmTomarFoto
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
            this.panTitle = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.pcbCamara = new System.Windows.Forms.PictureBox();
            this.cboDispocitivos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTomarFoto = new FontAwesome.Sharp.IconButton();
            this.panTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // panTitle
            // 
            this.panTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(48)))), ((int)(((byte)(247)))));
            this.panTitle.Controls.Add(this.iconButton2);
            this.panTitle.Controls.Add(this.btnClose);
            this.panTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panTitle.ForeColor = System.Drawing.Color.White;
            this.panTitle.Location = new System.Drawing.Point(0, 0);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(389, 39);
            this.panTitle.TabIndex = 15;
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
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 18;
            this.btnClose.Location = new System.Drawing.Point(349, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pcbCamara
            // 
            this.pcbCamara.Location = new System.Drawing.Point(12, 96);
            this.pcbCamara.Name = "pcbCamara";
            this.pcbCamara.Size = new System.Drawing.Size(364, 242);
            this.pcbCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCamara.TabIndex = 16;
            this.pcbCamara.TabStop = false;
            // 
            // cboDispocitivos
            // 
            this.cboDispocitivos.FormattingEnabled = true;
            this.cboDispocitivos.Location = new System.Drawing.Point(72, 65);
            this.cboDispocitivos.Name = "cboDispocitivos";
            this.cboDispocitivos.Size = new System.Drawing.Size(222, 25);
            this.cboDispocitivos.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(98, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Dispositivos de captura";
            // 
            // btnTomarFoto
            // 
            this.btnTomarFoto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTomarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTomarFoto.FlatAppearance.BorderSize = 0;
            this.btnTomarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTomarFoto.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.btnTomarFoto.IconColor = System.Drawing.Color.White;
            this.btnTomarFoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTomarFoto.IconSize = 25;
            this.btnTomarFoto.Location = new System.Drawing.Point(114, 344);
            this.btnTomarFoto.Name = "btnTomarFoto";
            this.btnTomarFoto.Size = new System.Drawing.Size(150, 40);
            this.btnTomarFoto.TabIndex = 25;
            this.btnTomarFoto.UseVisualStyleBackColor = false;
            this.btnTomarFoto.Click += new System.EventHandler(this.btnTomarFoto_Click);
            // 
            // frmTomarFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 395);
            this.Controls.Add(this.btnTomarFoto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDispocitivos);
            this.Controls.Add(this.pcbCamara);
            this.Controls.Add(this.panTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTomarFoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTomarFoto";
            this.Load += new System.EventHandler(this.frmTomarFoto_Load);
            this.panTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCamara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTitle;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.PictureBox pcbCamara;
        private System.Windows.Forms.ComboBox cboDispocitivos;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnTomarFoto;
    }
}